using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Functions
    {

        public static bool ValidarLogin(string login, string senha)
        {

            bool retorno = false;
            foreach (Usuario usuario in Usuario.Lista)
            {
                if (usuario.Login == login)
                {
                    if (usuario.Senha == senha)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;

        }

        public static bool VerificarUsuarioAdmin()
        {

            bool retorno = false;
            foreach (Usuario usuario in Usuario.Lista)
            {
                if (usuario.Login == "admin")
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }

        public static Usuario ObterUsuario(Int32 id)
        {
            Usuario usuario;
            return usuario = Usuario.Lista.Single(u => u.Id == id);
        
        }

    }
}