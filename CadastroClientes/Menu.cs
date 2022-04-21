using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
            lblUsuario.Text = ClassDadosGEt.Usuario;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes form1 = new CadastroClientes();
            form1.Show();
            this.Visible = false;
        }

        private void usuárioDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClassDadosGEt.Nivel == 1)
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario();
                cadastroUsuario.Show();
                this.Visible=false;
            }
            else
            {
                MessageBox.Show("Usuário sem permissão.", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você realmente deseja fechar o programa?","Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
