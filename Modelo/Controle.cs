using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Sistema.Modelo
{
    
   public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String email, String senha)
        {

            LoginDbComandos logindal = new LoginDbComandos();
            tem = logindal.verificarLogin(email, senha);
            if (!logindal.mensagem.Equals(""))
            {
                this.mensagem = logindal.mensagem;
            }
            return tem;
        }
        public String cadastrar(String nome, String email, String senha, String cofSenha)
        {
            return mensagem;
        }
    }
    }

