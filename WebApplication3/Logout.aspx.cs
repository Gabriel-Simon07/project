using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bool logado = false;
            string loginNome = string.Empty;

            if (HttpContext.Current.Session["NomeLogin"] != null)
            {
                logado = Convert.ToBoolean(Session["Logado"].ToString());               
                loginNome = Session["NomeLogin"].ToString();
            }

            if (logado)
            {
                LabelUsuarioLogado.Text = "Você esta logado como: " + loginNome + "!";
                BtnLogout.Visible = true;

            }
            else
            {
                BtnLogout.Visible = false;
                LabelUsuarioLogado.Text = "Não foi detectado usuário logado no sistema!";

            }

        }

        protected void Logout_Click(object sender, EventArgs e)
        {

            Session.Clear();

            Response.Redirect("Cadastro.aspx");
        }
    }
}