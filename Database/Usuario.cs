using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Usuario
    {

        public Usuario(string nome, string email, string login, string senha)
        {

            this.Nome = nome;
            this.Email = email;
            this.Login = login;
            this.Senha = senha;

        }

        public Usuario() { }
    }
}
