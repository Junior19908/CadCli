using LinqToDB;
using static LinqToDB.DataProvider.SqlServer.SqlServerProviderAdapter;

namespace CadastroClientes
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string ConnectionStringDataB;
                ConnectionStringDataB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\junio\source\repos\CadastroClientes\CadastroClientes\DataBase.mdf;Integrated Security=True";
                SqlConnection cnn;
                cnn = new SqlConnection(ConnectionStringDataB);
                cnn.Open();
                MessageBox.Show("Conectado!");
            }
            catch (Exception )
            {
                MessageBox.Show("Erro ao Conectar!");
            }
        }

        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {
            if(cmbEstado.SelectedIndex == 1)
            {
                
            }
        }
    }
}