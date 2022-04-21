using LinqToDB;
using System.Data;
using System.Data.OleDb;
using static LinqToDB.DataProvider.SqlServer.SqlServerProviderAdapter;

namespace CadastroClientes
{
    public partial class CadastroClientes : MetroFramework.Forms.MetroForm
    {
        public CadastroClientes()
        {
            InitializeComponent();
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    DataTable dtLista = new DataTable();
                    cmdSelect = new OleDbCommand("SELECT * FROM TB_ArquivoDBSCV ORDER BY col_id ASC");
                    cmdSelect.Connection = ClassConexao.DBSCV();
                    oleDbData = cmdSelect.ExecuteReader();
                    dtLista.Load(oleDbData);
                    dtGridArquivos.DataSource = dtLista;
                    ClassConexao.DBSCV().Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Conectar!");
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
        }
        //Variavéis Declaradas
        OleDbCommand command, cmdSelect, cmdAnexo;
        OleDbDataReader oleDbData;
        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimparTxtBox()
        {
            txtInfo.Clear();
            txtEstado.Text = "";
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtCNPJ.Clear();
            txtCPF.Clear();
            txtemail.Clear();
            txtInscricaoEstadual.Clear();
            txtBairro.Clear();
            txtCaminho.Clear();
            txtCelPessoal.Clear();
            txtCelSecundario.Clear();
            txtCep.Clear();
            txtCidade.Text = "";
            txtemail.Clear();
            txtNomeCompleto.Clear();
            txtNumEnd.Clear();
            txtRG.Clear();
            txtSite.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_ClienteDBSCV (col_nomeCompleto,col_Cpf,col_rg,col_cnpj,col_inscricao,col_celular1,col_celular2,col_endereco,col_estado,col_cidade,col_bairro,col_cep,col_numero,col_complemento,col_site,col_email,col_info,col_dataCadastro,col_usuarioCadastro,col_imagem) VALUES" +
                    "('" + txtNomeCompleto.Text + "','" + txtCPF.Text + "','" + txtRG.Text + "','" + txtCNPJ.Text + "','" + txtInscricaoEstadual.Text + "','" + txtCelPessoal.Text + "','" + txtCelSecundario.Text + "','" + txtEndereco.Text + "','" + txtEstado.Text + "','" + txtCidade.Text + "','" + txtBairro.Text + "','" + txtCep.Text + "','" + txtNumEnd.Text + "','" + txtComplemento.Text + "'" +
                    ",'" + txtSite.Text + "','" + txtemail.Text + "','" + txtInfo.Text + "', NOW(), '"+ ClassDadosGEt.IDUsuario +"','@foto')";

                command.ExecuteNonQuery();
                if (MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.OK)
                {
                    LimparTxtBox();
                    //ConsultarDataGrid();
                    ClassConexao.DBSCV().Close();
                }
            }
            catch(Exception Er)
            {

            }
        }

        private void dtGridArquivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtGridArquivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //StreamReader sr = new StreamReader(dtGridArquivos.SelectedRows[0].Cells["col_arquivo"].Value.ToString());
            //sr.Read();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}