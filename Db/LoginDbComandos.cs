using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Sistema.Modelo
{
    class LoginDbComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificar(String email, String senha)
        {
            // comandos sql para verificar se tem no banco 

            cmd.CommandText = "select * fron cadastro where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";

            }
            return tem;
        }

        internal bool verificarLogin(string email, string senha)
        {
            
            throw new NotImplementedException();
        }

        public String cadastrar(String nome, String email, String senha, String confSenha)
        {
            // comandos para inserir 
            return mensagem;
        }

    }
}
    

