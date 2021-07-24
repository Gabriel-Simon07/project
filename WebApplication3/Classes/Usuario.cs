using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Usuario
    {

        public Usuario() { }

        public Int32 Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Login { get; set; }

       // public string foto { get; set; }

        public static List<Usuario> Lista = new List<Usuario>();

        public List<Usuario> Todos()
        {

            return Usuario.Lista;

        }

        public void Salvar()
        {

            Usuario.Lista.Add(this);

        }
    }
}