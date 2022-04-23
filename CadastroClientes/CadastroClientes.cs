using LinqToDB;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using static LinqToDB.DataProvider.SqlServer.SqlServerProviderAdapter;

namespace CadastroClientes
{
    public partial class CadastroClientes : MetroFramework.Forms.MetroForm
    {
        public CadastroClientes()
        {
            InitializeComponent();
            CarregarGrid();
        }
        //Variavéis Declaradas
        OleDbCommand command, cmdSelect, cmdAnexo, comm;
        OleDbDataReader oleDbData;
        OleDbParameter paramFoto;
        int codClientID;
        byte[] foto;
        string caminhoArquivo;
        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarGrid()
        {
            try
            {
                codClientID = 2;
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    //codClientID++;
                    txtCodigoCliente.Text = codClientID.ToString();
                    DataTable dtLista = new DataTable();
                    cmdSelect = new OleDbCommand("SELECT * FROM TB_ArquivoDBSCV WHERE col_IDCliente=2 ORDER BY col_IdArquivo ASC");
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
            catch (OleDbException ex)
            {
                MessageBox.Show("Arquivo de Usuário não, encontrado!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
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
            picFoto.Image = null;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                command = ClassConexao.DBSCV().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TB_ClienteDBSCV (col_nomeCompleto,col_Cpf,col_rg,col_cnpj,col_inscricao,col_celular1,col_celular2,col_endereco,col_estado,col_cidade,col_bairro,col_cep,col_numero,col_complemento,col_site,col_email,col_info,col_dataCadastro,col_usuarioCadastro,col_imagem) VALUES" +
                    "('" + txtNomeCompleto.Text + "','" + txtCPF.Text + "','" + txtRG.Text + "','" + txtCNPJ.Text + "','" + txtInscricaoEstadual.Text + "','" + txtCelPessoal.Text + "','" + txtCelSecundario.Text + "','" + txtEndereco.Text + "','" + txtEstado.Text + "','" + txtCidade.Text + "','" + txtBairro.Text + "','" + txtCep.Text + "','" + txtNumEnd.Text + "','" + txtComplemento.Text + "'" +
                    ",'" + txtSite.Text + "','" + txtemail.Text + "','" + txtInfo.Text + "', NOW(), '"+ ClassDadosGEt.IDUsuario +"',@foto)";

                paramFoto = new OleDbParameter("@foto", OleDbType.Binary);
                paramFoto.Value = foto;
                command.Parameters.Add(paramFoto);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos imagem (*.BMP;*.JPG;*.GIF;.*JPEG)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(caminhoArquivo);
                picFoto.Image = bitmap;

                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                foto = ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picFoto.Image = null;
        }

        private void txtCodigoCliente_DoubleClick(object sender, EventArgs e)
        {

        }

        private void CadastroClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                txtCodigoCliente.Enabled = true;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\\Users\\junio\\AppData\\Local\\Temp\\tmpB78C.pdf");
                /*using (var comm = ClassConexao.DBSCV().CreateCommand())
                {
                    comm.CommandText = "SELECT col_arquivo FROM TB_ArquivoDBSCV WHERE col_idArquivo=@ID";
                    comm.Parameters.Add(new OleDbParameter("@ID", dtGridArquivos.CurrentRow.Cells["col_idArquivo"].Value));
                    var bytes = comm.ExecuteScalar() as byte[];
                    if (bytes != null)
                    {
                        var nomeArquivo = dtGridArquivos.CurrentRow.Cells["col_nomeArquivo"].Value.ToString();
                        var arquivoTemp = Path.GetTempFileName();
                        arquivoTemp = Path.ChangeExtension(arquivoTemp, Path.GetExtension(nomeArquivo));
                        File.WriteAllBytes(arquivoTemp, bytes);
                        Process.Start("C:\\Users\\junio\\AppData\\Local\\Temp\\tmpB78C.pdf");
                    }
                }*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnArquivo_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = codClientID.ToString();
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Arquivos para Anexar (*.PDF;*.DOC;*.XLS;*.XLSX)|*.PDF;*.DOC;*.XLS;*.XLSX| Todos os Arquivos (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var comm = ClassConexao.DBSCV().CreateCommand())
                    {
                        txtCaminho.Enabled = false;
                        txtCaminho.Text = caminhoArquivo = open.FileName;
                        if (MessageBox.Show("Deseja Enviar?","Informação",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            comm.CommandText = "INSERT INTO TB_ArquivoDBSCV(col_IDCliente, col_nomeArquivo, col_arquivo) VALUES ('" + txtCodigoCliente.Text + "', @NomeArquivo, @Arquivo)";
                            ConfigurarParametros(comm, caminhoArquivo);
                            comm.ExecuteNonQuery();
                            txtCaminho.Clear();
                            txtCaminho.Enabled = true;
                            CarregarGrid();
                        }
                        else
                        {
                            txtCaminho.Clear();
                            txtCaminho.Enabled = true;
                        }
                    }
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigurarParametros(OleDbCommand comm, string caminhoArquivo)
        {
            comm.Parameters.Add(new OleDbParameter("@NomeArquivo", Path.GetFileName(caminhoArquivo)));
            comm.Parameters.Add(new OleDbParameter("@Arquivo", File.ReadAllBytes(caminhoArquivo)));
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