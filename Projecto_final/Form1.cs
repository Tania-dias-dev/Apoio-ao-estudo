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
using BD_aulaSQL;
using MySql.Data.MySqlClient;

namespace Projecto_final
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public Form1()
        {
            InitializeComponent();

            string minhaConString = ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ToString();

            con = new MySqlConnection(minhaConString);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txt_user.Text;
                string pwd = txt_pwd.Text;

                string query = "Select * from tbl_login where lg_nome= @user and lg_pass = @pass";

                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["minhaConnectionApp"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pwd);

                        con.Open();

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Login efetuado com sucesso!\n", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // zero é a primeira coluna da tabela assim ja aparece o campo id na message box




                                Gerir_forms.TrocarForms(this, new frm_CRUD(user));

                            }


                            else
                            {



                                lblErro.Text = "Utilizador ou senha inválidos!";
                                lblErro.Visible = true;

                                txt_user.Clear();
                                txt_pwd.Clear();




                                // Dá foco à caixa de user
                                txt_user.Focus();


                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox:show ("Ocorreu um erro! Tente mais tarde!", "Erro", MessageBoxButtons.Ok, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            {
                // Alterna mostrar/esconder
                txt_pwd.UseSystemPasswordChar = !txt_pwd.UseSystemPasswordChar;

                // Alterna a imagem
                if (txt_pwd.UseSystemPasswordChar)
                    btnMostrarSenha.Image = Properties.Resources.hide; // password escondida
                else
                    btnMostrarSenha.Image = Properties.Resources.show;   // password visível

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMostrarSenha.HoverState.ImageSize = btnMostrarSenha.ImageSize;

        }
    }
}

