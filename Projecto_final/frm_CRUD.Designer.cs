namespace Projecto_final
{
    partial class frm_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CRUD));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabQuestoes = new System.Windows.Forms.TabPage();
            this.pictureBoxQuiz = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPergunta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnProxima = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnProx = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAnterior = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rbtnD = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnIniciar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCurso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabResultados = new System.Windows.Forms.TabPage();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabGestaoUsers = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fsdf = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_acesso = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_inserir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_atualizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabQuestoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiz)).BeginInit();
            this.tabResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tabGestaoUsers.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabQuestoes);
            this.tabControl1.Controls.Add(this.tabResultados);
            this.tabControl1.Controls.Add(this.tabGestaoUsers);
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(34, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 543);
            this.tabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabMenuBackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // tabQuestoes
            // 
            this.tabQuestoes.BackColor = System.Drawing.Color.Azure;
            this.tabQuestoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabQuestoes.Controls.Add(this.pictureBoxQuiz);
            this.tabQuestoes.Controls.Add(this.lblPergunta);
            this.tabQuestoes.Controls.Add(this.btnProxima);
            this.tabQuestoes.Controls.Add(this.btnProx);
            this.tabQuestoes.Controls.Add(this.btnAnterior);
            this.tabQuestoes.Controls.Add(this.rbtnD);
            this.tabQuestoes.Controls.Add(this.rbtnC);
            this.tabQuestoes.Controls.Add(this.rbtnB);
            this.tabQuestoes.Controls.Add(this.rbtnA);
            this.tabQuestoes.Controls.Add(this.btnIniciar);
            this.tabQuestoes.Controls.Add(this.label3);
            this.tabQuestoes.Controls.Add(this.cmbCurso);
            this.tabQuestoes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabQuestoes.Location = new System.Drawing.Point(184, 4);
            this.tabQuestoes.Name = "tabQuestoes";
            this.tabQuestoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestoes.Size = new System.Drawing.Size(688, 535);
            this.tabQuestoes.TabIndex = 0;
            this.tabQuestoes.Text = "Questões de estudo";
            // 
            // pictureBoxQuiz
            // 
            this.pictureBoxQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxQuiz.BorderRadius = 20;
            this.pictureBoxQuiz.ImageRotate = 0F;
            this.pictureBoxQuiz.Location = new System.Drawing.Point(407, 35);
            this.pictureBoxQuiz.Name = "pictureBoxQuiz";
            this.pictureBoxQuiz.Size = new System.Drawing.Size(233, 189);
            this.pictureBoxQuiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuiz.TabIndex = 15;
            this.pictureBoxQuiz.TabStop = false;
            this.pictureBoxQuiz.Visible = false;
            // 
            // lblPergunta
            // 
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPergunta.Location = new System.Drawing.Point(25, 182);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(134, 22);
            this.lblPergunta.TabIndex = 13;
            this.lblPergunta.Text = "guna2HtmlLabel2";
            this.lblPergunta.Visible = false;
            this.lblPergunta.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProxima.AutoRoundedCorners = true;
            this.btnProxima.BorderColor = System.Drawing.Color.Brown;
            this.btnProxima.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProxima.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProxima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProxima.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProxima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProxima.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btnProxima.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProxima.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnProxima.Location = new System.Drawing.Point(539, 473);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(62, 37);
            this.btnProxima.TabIndex = 12;
            this.btnProxima.Text = ">";
            this.btnProxima.Visible = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnProx
            // 
            this.btnProx.AutoRoundedCorners = true;
            this.btnProx.BorderColor = System.Drawing.Color.Brown;
            this.btnProx.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProx.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProx.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btnProx.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProx.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnProx.Location = new System.Drawing.Point(663, 593);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(73, 43);
            this.btnProx.TabIndex = 11;
            this.btnProx.Text = ">";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnterior.AutoRoundedCorners = true;
            this.btnAnterior.BorderColor = System.Drawing.Color.Brown;
            this.btnAnterior.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnterior.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnterior.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnterior.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnterior.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnterior.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnterior.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnAnterior.Location = new System.Drawing.Point(453, 473);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(62, 37);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<";
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnD.CheckedState.BorderThickness = 0;
            this.rbtnD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnD.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnD.CheckedState.InnerOffset = -4;
            this.rbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rbtnD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnD.Location = new System.Drawing.Point(25, 429);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(88, 24);
            this.rbtnD.TabIndex = 9;
            this.rbtnD.Text = "Opções";
            this.rbtnD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnD.UncheckedState.BorderThickness = 2;
            this.rbtnD.UncheckedState.FillColor = System.Drawing.Color.MediumOrchid;
            this.rbtnD.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnD.Visible = false;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnC.CheckedState.BorderThickness = 0;
            this.rbtnC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnC.CheckedState.InnerOffset = -4;
            this.rbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rbtnC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnC.Location = new System.Drawing.Point(25, 377);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(88, 24);
            this.rbtnC.TabIndex = 8;
            this.rbtnC.Text = "Opções";
            this.rbtnC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnC.UncheckedState.BorderThickness = 2;
            this.rbtnC.UncheckedState.FillColor = System.Drawing.Color.MediumOrchid;
            this.rbtnC.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnC.Visible = false;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnB.CheckedState.BorderThickness = 0;
            this.rbtnB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnB.CheckedState.InnerOffset = -4;
            this.rbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rbtnB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnB.Location = new System.Drawing.Point(25, 320);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(88, 24);
            this.rbtnB.TabIndex = 7;
            this.rbtnB.Text = "Opções";
            this.rbtnB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnB.UncheckedState.BorderThickness = 2;
            this.rbtnB.UncheckedState.FillColor = System.Drawing.Color.MediumOrchid;
            this.rbtnB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnB.Visible = false;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnA.CheckedState.BorderThickness = 0;
            this.rbtnA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnA.CheckedState.InnerOffset = -4;
            this.rbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rbtnA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnA.Location = new System.Drawing.Point(25, 265);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(88, 24);
            this.rbtnA.TabIndex = 6;
            this.rbtnA.Text = "Opções";
            this.rbtnA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnA.UncheckedState.BorderThickness = 2;
            this.rbtnA.UncheckedState.FillColor = System.Drawing.Color.MediumOrchid;
            this.rbtnA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnA.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoRoundedCorners = true;
            this.btnIniciar.BorderColor = System.Drawing.Color.Brown;
            this.btnIniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciar.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Location = new System.Drawing.Point(261, 95);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 34);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(1, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecione um Tema:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.AutoRoundedCorners = true;
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCurso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCurso.ItemHeight = 30;
            this.cmbCurso.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "Programação",
            "(Selecione...)"});
            this.cmbCurso.Location = new System.Drawing.Point(6, 95);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(231, 36);
            this.cmbCurso.StartIndex = 3;
            this.cmbCurso.TabIndex = 0;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmCurso_SelectedIndexChanged);
            // 
            // tabResultados
            // 
            this.tabResultados.BackColor = System.Drawing.Color.Azure;
            this.tabResultados.Controls.Add(this.dgvHistorico);
            this.tabResultados.Controls.Add(this.chartResultados);
            this.tabResultados.Controls.Add(this.guna2PictureBox1);
            this.tabResultados.Controls.Add(this.label5);
            this.tabResultados.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tabResultados.Location = new System.Drawing.Point(184, 4);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultados.Size = new System.Drawing.Size(688, 535);
            this.tabResultados.TabIndex = 1;
            this.tabResultados.Text = "Resultados";
            // 
            // chartResultados
            // 
            this.chartResultados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultados.Legends.Add(legend1);
            this.chartResultados.Location = new System.Drawing.Point(303, 57);
            this.chartResultados.Name = "chartResultados";
            this.chartResultados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResultados.Series.Add(series1);
            this.chartResultados.Size = new System.Drawing.Size(311, 230);
            this.chartResultados.TabIndex = 17;
            this.chartResultados.Text = "chart1";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = global::Projecto_final.Properties.Resources.resultados;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 143);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(251, 109);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(86, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resultados:";
            // 
            // tabGestaoUsers
            // 
            this.tabGestaoUsers.BackColor = System.Drawing.Color.Azure;
            this.tabGestaoUsers.Controls.Add(this.label8);
            this.tabGestaoUsers.Controls.Add(this.label7);
            this.tabGestaoUsers.Controls.Add(this.label6);
            this.tabGestaoUsers.Controls.Add(this.label4);
            this.tabGestaoUsers.Controls.Add(this.guna2PictureBox4);
            this.tabGestaoUsers.Controls.Add(this.guna2PictureBox3);
            this.tabGestaoUsers.Controls.Add(this.guna2PictureBox2);
            this.tabGestaoUsers.Controls.Add(this.btn_eliminar);
            this.tabGestaoUsers.Controls.Add(this.btn_atualizar);
            this.tabGestaoUsers.Controls.Add(this.btn_inserir);
            this.tabGestaoUsers.Controls.Add(this.txt_acesso);
            this.tabGestaoUsers.Controls.Add(this.txt_pass);
            this.tabGestaoUsers.Controls.Add(this.txt_nome);
            this.tabGestaoUsers.Controls.Add(this.txt_id);
            this.tabGestaoUsers.Controls.Add(this.dgvUsuarios);
            this.tabGestaoUsers.Location = new System.Drawing.Point(184, 4);
            this.tabGestaoUsers.Name = "tabGestaoUsers";
            this.tabGestaoUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestaoUsers.Size = new System.Drawing.Size(688, 535);
            this.tabGestaoUsers.TabIndex = 2;
            this.tabGestaoUsers.Text = "Gestão utilizadores";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(870, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lblData);
            this.guna2Panel1.Controls.Add(this.lblNivel);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.lblNome);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(34, 56);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(876, 56);
            this.guna2Panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(336, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de acesso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bem-vindo/a:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblData.Location = new System.Drawing.Point(688, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "label1";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNivel.Location = new System.Drawing.Point(483, 15);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(59, 20);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "label1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(248)))));
            this.guna2Panel2.Location = new System.Drawing.Point(-27, 43);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(903, 10);
            this.guna2Panel2.TabIndex = 2;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(144, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "label1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            // 
            // fsdf
            // 
            this.fsdf.BackColor = System.Drawing.Color.Transparent;
            this.fsdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsdf.Location = new System.Drawing.Point(25, 171);
            this.fsdf.Name = "fsdf";
            this.fsdf.Size = new System.Drawing.Size(179, 27);
            this.fsdf.TabIndex = 5;
            this.fsdf.Text = "Questoes de estudo";
            this.fsdf.Visible = false;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToResizeColumns = false;
            this.dgvHistorico.AllowUserToResizeRows = false;
            this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(6, 327);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.RowHeadersVisible = false;
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(642, 150);
            this.dgvHistorico.TabIndex = 18;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.MediumOrchid;
            this.dgvUsuarios.Location = new System.Drawing.Point(50, 319);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(469, 180);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.AutoRoundedCorners = true;
            this.txt_id.BorderColor = System.Drawing.Color.MediumOrchid;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(106, 56);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(271, 34);
            this.txt_id.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.AutoRoundedCorners = true;
            this.txt_nome.BorderColor = System.Drawing.Color.Navy;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.DefaultText = "";
            this.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Location = new System.Drawing.Point(106, 132);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(271, 34);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.AutoRoundedCorners = true;
            this.txt_pass.BorderColor = System.Drawing.Color.MediumOrchid;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Location = new System.Drawing.Point(106, 198);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(271, 34);
            this.txt_pass.TabIndex = 5;
            // 
            // txt_acesso
            // 
            this.txt_acesso.AutoRoundedCorners = true;
            this.txt_acesso.BorderColor = System.Drawing.Color.Navy;
            this.txt_acesso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_acesso.DefaultText = "";
            this.txt_acesso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_acesso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_acesso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_acesso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_acesso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_acesso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_acesso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_acesso.Location = new System.Drawing.Point(110, 255);
            this.txt_acesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_acesso.Name = "txt_acesso";
            this.txt_acesso.PlaceholderText = "";
            this.txt_acesso.SelectedText = "";
            this.txt_acesso.Size = new System.Drawing.Size(271, 34);
            this.txt_acesso.TabIndex = 10;
            // 
            // btn_inserir
            // 
            this.btn_inserir.AutoRoundedCorners = true;
            this.btn_inserir.BorderColor = System.Drawing.Color.Brown;
            this.btn_inserir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inserir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inserir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inserir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inserir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inserir.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btn_inserir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inserir.Location = new System.Drawing.Point(423, 47);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(124, 43);
            this.btn_inserir.TabIndex = 11;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.AutoRoundedCorners = true;
            this.btn_atualizar.BorderColor = System.Drawing.Color.Brown;
            this.btn_atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_atualizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_atualizar.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btn_atualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_atualizar.Location = new System.Drawing.Point(423, 119);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(124, 46);
            this.btn_atualizar.TabIndex = 12;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoRoundedCorners = true;
            this.btn_eliminar.BorderColor = System.Drawing.Color.Brown;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_eliminar.Location = new System.Drawing.Point(423, 203);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(124, 44);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox2.BorderRadius = 20;
            this.guna2PictureBox2.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.InitialImage")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(593, 47);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 43);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox3.BorderRadius = 20;
            this.guna2PictureBox3.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.InitialImage")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(593, 119);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(42, 38);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 15;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox4.BorderRadius = 20;
            this.guna2PictureBox4.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.InitialImage")));
            this.guna2PictureBox4.Location = new System.Drawing.Point(593, 203);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(50, 44);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 16;
            this.guna2PictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(69, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(36, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(2, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(45, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nível";
            // 
            // frm_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 702);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CRUD";
            this.Load += new System.EventHandler(this.frm_CRUD_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuestoes.ResumeLayout(false);
            this.tabQuestoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiz)).EndInit();
            this.tabResultados.ResumeLayout(false);
            this.tabResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tabGestaoUsers.ResumeLayout(false);
            this.tabGestaoUsers.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabPage tabGestaoUsers;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblNome;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNivel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabQuestoes;
        private Guna.UI2.WinForms.Guna2GradientButton btnProx;
        private Guna.UI2.WinForms.Guna2GradientButton btnAnterior;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnD;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnC;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnB;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnA;
        private Guna.UI2.WinForms.Guna2GradientButton btnIniciar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCurso;
        private Guna.UI2.WinForms.Guna2HtmlLabel fsdf;
        private Guna.UI2.WinForms.Guna2GradientButton btnProxima;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPergunta;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxQuiz;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private Guna.UI2.WinForms.Guna2TextBox txt_acesso;
        private Guna.UI2.WinForms.Guna2GradientButton btn_atualizar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_inserir;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_eliminar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}