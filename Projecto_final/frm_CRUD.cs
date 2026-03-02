using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_final
{
    public partial class frm_CRUD : Form
    {
        private string usuarioLogado;

        private string usuario;

        int idQuestionarioAtual;


        List<Pergunta> perguntasQuiz = new List<Pergunta>();
        Dictionary<int, string> respostasUser = new Dictionary<int, string>();
        int perguntaAtual = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString;

        public frm_CRUD(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }
        /*
        public frm_CRUD()

        {
            InitializeComponent();
            usuarioLogado = usuario;
        }
        */
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CRUD_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            {
                string query = "SELECT lg_nome, lg_acesso FROM tbl_login WHERE lg_nome = @user";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user", usuarioLogado); // passar o user logado
                    con.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lblNome.Text = dr["lg_nome"].ToString();
                            lblNivel.Text = dr["lg_acesso"].ToString();
                            if (dr["lg_acesso"].ToString() != "admin")
                            {
                                tabControl1.TabPages.Remove(tabGestaoUsers);
                            }
                        }
                    }
                }
            }
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

        }

        private void cmCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCurso.SelectedIndex)
            {
                case 0: // Matemática
                    pictureBoxQuiz.Image = Properties.Resources.Matematica;
                    break;
                case 1: // Português
                    pictureBoxQuiz.Image = Properties.Resources.Portugues;
                    break;
                case 2: // Programação
                    pictureBoxQuiz.Image = Properties.Resources.programacao;
                    break;
                default:
                    pictureBoxQuiz.Image = null; // nada selecionado
                    break;


            }
            pictureBoxQuiz.Visible = true;

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {


            if (cmbCurso.SelectedIndex == 3)
            {
                MessageBox.Show("Escolhe um curso antes de iniciar!");
                return;
            }

            int idCurso = cmbCurso.SelectedIndex + 1; // 1 = Matemática, 2 = Português, 3 = Programação

            perguntasQuiz.Clear();
            respostasUser.Clear();
            perguntaAtual = 0;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"SELECT * FROM questionario_perguntas 
                         WHERE id_questionario = @id 
                         ORDER BY RAND() 
                         LIMIT 10";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", idCurso);
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Pergunta p = new Pergunta()
                            {
                                Id = Convert.ToInt32(dr["id_pergunta"]),
                                Texto = dr["pergunta"].ToString(),
                                OpcaoA = dr["opcaoA"].ToString(),
                                OpcaoB = dr["opcaoB"].ToString(),
                                OpcaoC = dr["opcaoC"].ToString(),
                                OpcaoD = dr["opcaoD"].ToString(),
                                RespostaCorreta = dr["resposta_correta"].ToString()
                            };
                            perguntasQuiz.Add(p);
                        }
                    }
                }
            }

            if (perguntasQuiz.Count > 0)
                MostrarPergunta();

            lblPergunta.Visible = true;
            rbtnA.Visible = true;
            rbtnB.Visible = true;
            rbtnC.Visible = true;
            rbtnD.Visible = true;
            btnProxima.Visible = true;
            btnAnterior.Visible = true;

            idCurso = cmbCurso.SelectedIndex + 1;
            idQuestionarioAtual = idCurso;

        }





        void MostrarPergunta()
        {
            Pergunta p = perguntasQuiz[perguntaAtual];
            lblPergunta.Text = p.Texto;
            rbtnA.Text = p.OpcaoA;
            rbtnB.Text = p.OpcaoB;
            rbtnC.Text = p.OpcaoC;
            rbtnD.Text = p.OpcaoD;

            // Limpar seleção
            rbtnA.Checked = rbtnB.Checked = rbtnC.Checked = rbtnD.Checked = false;

            // Se já respondeu antes, marcar a opção escolhida
            if (respostasUser.ContainsKey(p.Id))
            {
                string r = respostasUser[p.Id];
                rbtnA.Checked = r == "A";
                rbtnB.Checked = r == "B";
                rbtnC.Checked = r == "C";
                rbtnD.Checked = r == "D";
            }
        }

        void GuardarResposta()
        {
            string respostaEscolhida = "";
            if (rbtnA.Checked) respostaEscolhida = "A";
            else if (rbtnB.Checked) respostaEscolhida = "B";
            else if (rbtnC.Checked) respostaEscolhida = "C";
            else if (rbtnD.Checked) respostaEscolhida = "D";

            if (respostaEscolhida != "")
                respostasUser[perguntasQuiz[perguntaAtual].Id] = respostaEscolhida;
        }

        void MostrarPontuacao()
        {
            int acertos = 0;

            foreach (var p in perguntasQuiz)
            {
                if (respostasUser.ContainsKey(p.Id) && respostasUser[p.Id] == p.RespostaCorreta)
                    acertos++;
            }




        }
        private void MostrarGrafico()
        {
            chartResultados.Series.Clear();
            chartResultados.Titles.Clear();
            chartResultados.Legends.Clear();

            chartResultados.Titles.Add("Resultados do Quiz");
            chartResultados.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("Legenda"));

            int certas = 0;
            int erradas = 0;

            foreach (var p in perguntasQuiz)
            {
                if (respostasUser.ContainsKey(p.Id) && respostasUser[p.Id] == p.RespostaCorreta)
                    certas++;
                else
                    erradas++;
            }

            // Série para respostas certas
            var serieCertas = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Certas",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,

                Legend = "Legenda"
            };
            serieCertas.Points.AddXY("Certas", certas);

            // Série para respostas erradas
            var serieErradas = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Erradas",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,

                Legend = "Legenda"
            };
            serieErradas.Points.AddXY("Erradas", erradas);

            chartResultados.Series.Add(serieCertas);
            chartResultados.Series.Add(serieErradas);

            // Remove gridlines do fundo
            chartResultados.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartResultados.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartResultados.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            chartResultados.Invalidate();
        }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnProxima_Click(object sender, EventArgs e)
        {


            {
                // Guarda a resposta selecionada antes de avançar
                GuardarResposta();

                // Passa para a próxima pergunta
                if (perguntaAtual < perguntasQuiz.Count - 1)
                {
                    perguntaAtual++;
                    MostrarPergunta();
                }
                else
                {
                    // Última pergunta → mostrar pontuação
                    MessageBox.Show("Esta é a última pergunta. Vamos passar aos resultados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarPontuacao();
                    MostrarGrafico();
                    int acertos = CalcularAcertos();
                    GuardarHistorico(acertos);
                    CarregarHistorico();


                    tabControl1.SelectedTab = tabResultados;


                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {


            // Guarda a resposta atual antes de voltar
            GuardarResposta();

            if (perguntaAtual > 0)
            {
                perguntaAtual--;
                MostrarPergunta();
            }
            else
            {
                MessageBox.Show("Esta é a primeira pergunta. Não é possível recuar mais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Cores do gradiente
            Color cor1 = Color.LightBlue;
            Color cor2 = Color.DarkViolet;

            // Cria o gradiente
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(guna2Panel2.ClientRectangle, cor1, cor2, 45f)) // 45 graus
            {
                e.Graphics.FillRectangle(brush, guna2Panel2.ClientRectangle);
            }


        }

        void GuardarHistorico(int acertos)
        {
            using (MySqlConnection conHist = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO historico_quiz 
        (id_utilizador, id_questionario, acertos, total)
        VALUES (
            (SELECT id FROM tbl_login WHERE lg_nome=@user),
            @q,
            @a,
            @t
        )";

                using (MySqlCommand cmd = new MySqlCommand(query, conHist))
                {
                    cmd.Parameters.AddWithValue("@user", usuarioLogado);
                    cmd.Parameters.AddWithValue("@q", idQuestionarioAtual);
                    cmd.Parameters.AddWithValue("@a", acertos);
                    cmd.Parameters.AddWithValue("@t", perguntasQuiz.Count);

                    conHist.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        int CalcularAcertos()
        {
            int acertos = 0;

            foreach (var p in perguntasQuiz)
            {
                if (respostasUser.ContainsKey(p.Id) && respostasUser[p.Id] == p.RespostaCorreta)
                    acertos++;
            }

            return acertos;
        }
        void CarregarHistorico()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string queryHist = @"
            SELECT 
                h.id,
                u.lg_nome AS Utilizador,
                q.nome AS Questionario,
                h.acertos AS Acertos,
                h.total AS Total,
                h.data_realizacao AS Data
            FROM historico_quiz h
            JOIN tbl_login u ON h.id_utilizador = u.id
            JOIN questionario q ON h.id_questionario = q.id_questionario
            ORDER BY h.data_realizacao DESC";

                using (MySqlDataAdapter da = new MySqlDataAdapter(queryHist, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHistorico.DataSource = dt;

                    // Exibir cabeçalhos
                    dgvHistorico.ColumnHeadersVisible = true;


                    dgvHistorico.Columns["Utilizador"].HeaderText = "Utilizador";
                    dgvHistorico.Columns["Questionario"].HeaderText = "Questionário";
                    dgvHistorico.Columns["Acertos"].HeaderText = "Respostas certas";
                    dgvHistorico.Columns["Total"].HeaderText = "Nº de Questões";
                    dgvHistorico.Columns["Data"].HeaderText = "Data de Realização";

                    // Formatar colunas
                    dgvHistorico.Columns["Acertos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvHistorico.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvHistorico.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";



                    dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    // Impedir que o utilizador adicione linhas manualmente
                    dgvHistorico.AllowUserToAddRows = false;

                    // Permitir seleção de linha inteira
                    dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Opcional: desativar edição
                    dgvHistorico.ReadOnly = true;


                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a aba selecionada é a de resultados , para que o historico esteja sempre disponivel
            if (tabControl1.SelectedTab == tabResultados)
            {
                CarregarHistorico();
            }
            else if (tabControl1.SelectedTab == tabGestaoUsers)
            {
                CarregarUsuarios();
            }
        }
        void CarregarUsuarios()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, lg_nome AS Nome, lg_acesso AS Nivel,lg_pass AS Password FROM tbl_login ORDER BY lg_nome";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;

                    // Ajusta as colunas para preencher horizontalmente sem mudar tamanho do DataGridView
                    foreach (DataGridViewColumn col in dgvUsuarios.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    //linhas
                    dgvUsuarios.AllowUserToAddRows = false;

                    // Apenas leitura
                    dgvUsuarios.ReadOnly = true;


                }
            }
        }
        private void atualizar() //método para atualizar o DataGridView
        {
            string query = "select * from tbl_login;";

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }


        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string query = "insert into tbl_login (lg_nome,lg_pass,lg_acesso) values (@nome, @pass, @acesso);";
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                cmd.Parameters.AddWithValue("@acesso", txt_acesso.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("registo feito com sucesso");


                    atualizar();
                    txt_id.Clear();
                    txt_nome.Clear();
                    txt_pass.Clear();
                    txt_acesso.Clear();
                }
                else
                {
                    MessageBox.Show("erro ao inserir registo");
                }
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            string query = "update tbl_login set lg_nome=@nome, lg_pass=@pass, lg_acesso=@acesso where id=@id";
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text)); //converter o id para int porque na base de dados o id é int
                cmd.Parameters.AddWithValue("@acesso", txt_acesso.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Nenhum registo foi actualizado");

                }
                else
                {
                    MessageBox.Show("Registo actualizado com sucesso!");
                    atualizar();

                    txt_id.Clear();
                    txt_nome.Clear();
                    txt_pass.Clear();
                    txt_acesso.Clear();

                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_id.Text, out int id))
            {
                MessageBox.Show("ID inválido");
                txt_id.Clear();
                return;
            }

            string query = "DELETE FROM tbl_login WHERE id=@id";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Utilizador não encontrado.");
                        txt_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Utilizador eliminado com sucesso!");
                        atualizar();
                        txt_id.Clear();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    //  foreign key
                    if (ex.Number == 1451)
                    {
                        MessageBox.Show("Não é possível eliminar este utilizador porque tem histórico associado.");
                        txt_id.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);

                    }
                }
            }

                }
            }

        }
    


    
    

