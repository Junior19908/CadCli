using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();

        }
        public bool FMP = false;
        public void Logar()
        {

            try
            {
                if(ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    //Conexão do formulário com o Banco de Dados
                    string tb_usuario = "SELECT col_id,col_usuario, col_senha, col_status, col_nivel FROM TB_LoginDBSCV WHERE col_usuario = @usuario";
                    OleDbCommand oleDbCommand = new OleDbCommand(tb_usuario, ClassConexao.DBSCV());
                    oleDbCommand.Parameters.Add(new OleDbParameter("@usuario", txtUsuarioLogin.Text));
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    //Coleta as informações e armazena para futuras consultas
                    while (oleDbDataReader.Read())
                    {
                        ClassDadosGEt.Usuario = Convert.ToString(oleDbDataReader["col_usuario"]);
                        ClassDadosGEt.Senha = Convert.ToString(oleDbDataReader["col_senha"]);
                        ClassDadosGEt.Status = Convert.ToInt32(oleDbDataReader["col_status"]);
                        ClassDadosGEt.Nivel = Convert.ToInt32(oleDbDataReader["col_nivel"]);
                        ClassDadosGEt.IDUsuario = Convert.ToInt32(oleDbDataReader["col_id"]);
                    }

                    //Verifica se a senha está correta
                    if (ClassDadosGEt.Senha == txtSenhaLogin.Text)
                    {
                        //Verifica se o status do usuário é Ativo(1) ou Desativado(2)
                        if (ClassDadosGEt.Status == 1)
                        {
                            FMP = true;
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Desativado!");
                        }
                    }
                    //Caso esteja errada a senha ele cai nesse else
                    else
                    {
                        MessageBox.Show("Usuário Não Logado!");
                    }
                }
                //Else caso a conexão esteja fechada
                else
                {
                    MessageBox.Show("Erro ao Conectar ao Banco de Dados");
                }
            }
            //Tratamento do Erro no Banco de Dados
            catch (OleDbException DBError)
            {
                MessageBox.Show("Erro com o Banco de Dados! " + DBError.Message +"","<- Banco de Dados ->",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (ClassConexao.DBSCV().State == ConnectionState.Open)
                {
                    
                }
            }
            catch (OleDbException)
            {
                ConfigConexao configConexao = new ConfigConexao();
                configConexao.ShowDialog();
                //this.Dispose();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
