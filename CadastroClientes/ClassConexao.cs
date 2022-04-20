using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CadastroClientes
{
    internal class ClassConexao
    {
        public static OleDbConnection DBSCV()
        {
            OleDbConnection CONEX = new OleDbConnection();
            CONEX.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SISTEMADECADASTRO\DBSCV.accdb";
            CONEX.Open();
            return CONEX;
        }
    }
}
