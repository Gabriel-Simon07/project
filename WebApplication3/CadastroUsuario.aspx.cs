using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string operacao = Request.QueryString["operacao"];
            if (operacao != null)
            {

                //foreach (String item in Request.QueryString.Keys)
                //{
                //    lblOperacao.Text += "Chave= " + item + " --> " + Request.QueryString[item] + "";
                //}

                if (!IsPostBack)
                {
                    if (operacao == "INS") //--Inserir
                    {
                        inputUsuarioNome.Text = string.Empty;
                        inputUsuarioEmail.Text = string.Empty;
                        inputCadastroLogin.Text = string.Empty;
                        inputCadastroSenha.Text = string.Empty;
                        btnIncluir.Visible = true;
                        btnAtualiza.Visible = false;
                        btnExcluir.Visible = false;

                    }
                    else if (operacao == "UPD") //-Atualizar
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            inputId.Text = usuario.Id.ToString();

                            btnIncluir.Visible = false;
                            btnAtualiza.Visible = true;
                            btnExcluir.Visible = false;

                            
                        }

                    }
                    else if (operacao == "DEL") //--Deletar
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            inputId.Text = usuario.Id.ToString();

                            btnIncluir.Visible = false;
                            btnAtualiza.Visible = false;
                            btnExcluir.Visible = true;
                        }

                    }
                    else
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            Int32 id = int.Parse(Request.QueryString["id"]);
                            Usuario usuario = Functions.ObterUsuario(id);
                            inputUsuarioNome.Text = usuario.Nome;
                            inputUsuarioEmail.Text = usuario.Email;
                            inputCadastroLogin.Text = usuario.Login;
                            inputCadastroSenha.Text = usuario.Senha;
                            //operacao == "DSP" --Display
                            btnIncluir.Visible = false;
                            btnAtualiza.Visible = false;
                            btnExcluir.Visible = false;
                        }
                    }
                }
            }
        }

        protected void BtnIncluir_Click(object sender, EventArgs e)
        {

            CadastrarUsuario(inputUsuarioNome.Text, inputUsuarioEmail.Text, inputCadastroLogin.Text, inputCadastroSenha.Text);

            //--Voltar para a tela de lista de usuários
            Response.Redirect("Cadastro.aspx");

        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {

            AtualizarUsuario(inputId.Text, inputUsuarioNome.Text, inputUsuarioEmail.Text, inputCadastroLogin.Text, inputCadastroSenha.Text);

            //--Voltar para a tela de lista de usuários
            Response.Redirect("Cadastro.aspx");

        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {

            RemoverUsuario(inputId.Text);

            //--Voltar para a tela de lista de usuários
            Response.Redirect("Cadastro.aspx");

        }


        private void CadastrarUsuario(string nome, string email, string login, string senha)
        {
            //--obter proximo id
            Int32 id = 1;
            if (Usuario.Lista.Count > 0)
            {
                var ultimoUsuario = Usuario.Lista[Usuario.Lista.Count - 1];
                id = ultimoUsuario.Id + 1;
            }

            var usuario = new Usuario();
            usuario.Id = id;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Login = login;
            usuario.Senha = senha;
            usuario.Salvar();

        }

        private void AtualizarUsuario(string id, string nome, string email, string login, string senha)
        {

            Usuario usuario = Functions.ObterUsuario(int.Parse(id));
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Login = login;
            usuario.Senha = senha;
        }

        private void RemoverUsuario(string id)
        {
            Usuario usuario = Functions.ObterUsuario(int.Parse(id));
            Usuario.Lista.Remove(usuario);
        }


    }
}
