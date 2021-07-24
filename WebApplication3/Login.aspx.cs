using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Cadastro2 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) { 
                inputLogin.Text = string.Empty;
                inputSenha.Text = string.Empty;
            }

            //--Verificar se existe um usuário admin cadastrado
            if (Functions.VerificarUsuarioAdmin())
            {
                //--Se houver NÃO EXIBE botão de criar usuário admin
                btnCriarUsuarioAdmin.Visible = false;
            }
            else
            {
                //--Se houver EXIBE botão de criar usuário admin
                btnCriarUsuarioAdmin.Visible = true;
            }

            //--Verifica se existe sessão criada
            if (HttpContext.Current.Session["Logado"] == null)
            {
                Session["Login"] = string.Empty;
                Session["Logado"] = false;
            }

        }

        protected void BtnConfirmarLogin_Click(object sender, EventArgs e)
        {

            bool temError = false;
            string mensagemErro = string.Empty;

            string senha = inputSenha.Text;
            string login = inputLogin.Text;

            if (!temError)
            {

                if (login == string.Empty)
                {
                    temError = true;
                    mensagemErro = "Informe um login valido! (" + login + ")";
                }
            }

            if (!temError)
            {
                if (senha == string.Empty)
                {
                    temError = true;
                    mensagemErro = "Informe uma senha válida!";
                }
            }

            if (!temError)
            {
                if (Functions.ValidarLogin(login, senha))
                {
                    Session["NomeLogin"] = login;
                    Session["Logado"] = true;
                    inputLogin.Enabled = false;
                    inputSenha.Visible = false;
                    btnConfirmaLogin.Visible = false;

                }
                else
                {
                    temError = true;
                    mensagemErro = "usuário ou senha incorreto!(" + login + ")(" + senha + ")";
                }
            }


            if (temError)
            {
                Response.Write("<script>alert('Erro: " + mensagemErro + " " + login + "')</script>");
            }

        }

        protected void BtnCriarUsuarioAdmin_Click(object sender, EventArgs e)
        {
            CriarUsuarioAdmin();
            btnCriarUsuarioAdmin.Visible = false;
            Response.Write("<script>alert('Usuário admin criado com sucesso!')</script>");
        }


        private void CriarUsuarioAdmin()
        {

            if (!Functions.VerificarUsuarioAdmin())
            {
                var usuario = new Usuario();
                usuario.Id = 1;
                usuario.Nome = "admin";
                usuario.Email = "admin";
                usuario.Login = "admin";
                usuario.Senha = "admin";
                usuario.Salvar();
            }
        }
    }
}