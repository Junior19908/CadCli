namespace CadastroClientes
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeiroToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendaToolStripMenuItem.Text = "Vendas";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuárioDoSistemaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // usuárioDoSistemaToolStripMenuItem
            // 
            this.usuárioDoSistemaToolStripMenuItem.Name = "usuárioDoSistemaToolStripMenuItem";
            this.usuárioDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioDoSistemaToolStripMenuItem.Text = "Usuário do Sistema";
            this.usuárioDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuárioDoSistemaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 66);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CadastroClientes.Properties.Resources.banner_app_logo4996964065204094170;
            this.pictureBox2.Location = new System.Drawing.Point(503, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(13, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(203, 39);
            this.label17.TabIndex = 0;
            this.label17.Text = "Menu do Sistema";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbluser,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(20, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(613, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbluser
            // 
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(50, 17);
            this.lbluser.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(29, 17);
            this.lblUsuario.Text = "user";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(523, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "R$ 10,25";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(526, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vendas de Hoje";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(20, 295);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 362);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuárioDoSistemaToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label17;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbluser;
        private ToolStripStatusLabel lblUsuario;
        private TextBox textBox1;
        private Label label1;
        private Button btnSair;
        private ToolStripMenuItem ajudaToolStripMenuItem;
    }
}