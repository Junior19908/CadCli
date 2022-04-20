namespace CadastroClientes
{
    partial class CadastroUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGridUsuarios = new System.Windows.Forms.DataGridView();
            this.IDENTF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadastroClientes.Properties.Resources.banner_app_logo4996964065204094170;
            this.pictureBox1.Location = new System.Drawing.Point(645, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo de Cadastro de Usuário do Sistema";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 295);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtCodigoUsuario);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.btnRemover);
            this.tabPage1.Controls.Add(this.btnAdicionar);
            this.tabPage1.Controls.Add(this.picFoto);
            this.tabPage1.Controls.Add(this.cmbNivel);
            this.tabPage1.Controls.Add(this.cmbStatus);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmailUsuario);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSenhaUsuario);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNomeCompleto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro/Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(587, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Código do Usuário";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Enabled = false;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(128, 23);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoUsuario.TabIndex = 16;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(668, 238);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(517, 155);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(517, 129);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(598, 23);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(143, 156);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 12;
            this.picFoto.TabStop = false;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.cmbNivel.Location = new System.Drawing.Point(128, 201);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 23);
            this.cmbNivel.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cmbStatus.Location = new System.Drawing.Point(128, 172);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(98, 23);
            this.cmbStatus.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nivel de Autorização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(128, 143);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(207, 23);
            this.txtEmailUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(128, 114);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.PlaceholderText = "Digite Aqui!";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(207, 23);
            this.txtSenhaUsuario.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(128, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(207, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(128, 54);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(354, 23);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGridUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuários Cadastrador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGridUsuarios
            // 
            this.dtGridUsuarios.AllowUserToAddRows = false;
            this.dtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDENTF,
            this.NOME,
            this.LOGIN,
            this.SENHA,
            this.EMAIL,
            this.NIVEL,
            this.STATUS,
            this.DATA});
            this.dtGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dtGridUsuarios.Name = "dtGridUsuarios";
            this.dtGridUsuarios.RowTemplate.Height = 25;
            this.dtGridUsuarios.Size = new System.Drawing.Size(743, 261);
            this.dtGridUsuarios.TabIndex = 0;
            // 
            // IDENTF
            // 
            this.IDENTF.DataPropertyName = "col_id";
            this.IDENTF.HeaderText = "IDEN";
            this.IDENTF.Name = "IDENTF";
            this.IDENTF.Visible = false;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "col_nome";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // LOGIN
            // 
            this.LOGIN.DataPropertyName = "col_usuario";
            this.LOGIN.HeaderText = "LOGIN";
            this.LOGIN.Name = "LOGIN";
            // 
            // SENHA
            // 
            this.SENHA.DataPropertyName = "col_senha";
            dataGridViewCellStyle1.Format = "*";
            this.SENHA.DefaultCellStyle = dataGridViewCellStyle1;
            this.SENHA.HeaderText = "SENHA";
            this.SENHA.Name = "SENHA";
            this.SENHA.Visible = false;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "col_email";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "col_nivel";
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "col_status";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "col_cadastro";
            this.DATA.HeaderText = "DATA DE CADASTRO";
            this.DATA.Name = "DATA";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(6, 238);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "CadastroUsuario";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtNomeCompleto;
        private Label label2;
        private Label label4;
        private TextBox txtSenhaUsuario;
        private TextBox txtUsuario;
        private Label label3;
        private ComboBox cmbNivel;
        private ComboBox cmbStatus;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtEmailUsuario;
        private PictureBox picFoto;
        private Button btnAdicionar;
        private Button btnGravar;
        private Button btnRemover;
        private Label label8;
        private TextBox txtCodigoUsuario;
        private DataGridView dtGridUsuarios;
        private DataGridViewTextBoxColumn IDENTF;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn LOGIN;
        private DataGridViewTextBoxColumn SENHA;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn NIVEL;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn DATA;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}