using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Sistema
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @" Server= localhost,1433;Initial Catalog=cadastro;Integrated Security=False; User Id=sa;Password=MyPass@word";
        }
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
