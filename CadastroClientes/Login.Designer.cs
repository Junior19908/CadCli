namespace CadastroClientes
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErroSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(442, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 419);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CadastroClientes.Properties.Resources.Huvafen_Fushi_Sunrise_Dawn_Maldives_Overwater_Spa_Paul_Reiffer_Professional_Landscape_Photograph_Photographer_Pink_Blue_Sea_Ocean_Jetty_Wooden_Per_Aquum_2x;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblErroSenha);
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSenhaLogin);
            this.panel2.Controls.Add(this.txtUsuarioLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 419);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(170, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "1ª Tentativa";
            this.label2.Visible = false;
            // 
            // lblErroSenha
            // 
            this.lblErroSenha.AutoSize = true;
            this.lblErroSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErroSenha.ForeColor = System.Drawing.Color.Red;
            this.lblErroSenha.Location = new System.Drawing.Point(91, 149);
            this.lblErroSenha.Name = "lblErroSenha";
            this.lblErroSenha.Size = new System.Drawing.Size(236, 17);
            this.lblErroSenha.TabIndex = 4;
            this.lblErroSenha.Text = "Erro ao digitar a Senha ou o Usuário!";
            this.lblErroSenha.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(114, 308);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(186, 55);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 40.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem Vindo!";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(100, 224);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(215, 23);
            this.txtSenhaLogin.TabIndex = 1;
            this.txtSenhaLogin.Text = "02984646#Lua";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(100, 195);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(215, 23);
            this.txtUsuarioLogin.TabIndex = 0;
            this.txtUsuarioLogin.Text = "carlosjunyoor";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblErroSenha;
        private Button btnEntrar;
        private Label label1;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label label2;
    }
}