using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {

        protected void BtnOK_Click(object sender, EventArgs e)
        {

            String nomeCompleto = InputNome.Text + " " + InputSobrenome.Text;

            //--47123456789 -> (47) 12345-6789
            String telefoneFormatado = long.Parse(InpuTelefone.Text).ToString(@"(00) 00000-0000");

            DateTime dataNascimento = DateTime.Parse(InputDatanasc.Text);

            String idadeDias = CalculaIdade(dataNascimento);

            Response.Write($"Nome completo: {nomeCompleto} </br>");
            Response.Write($"Telefone: {telefoneFormatado} </br>");
            Response.Write($"Email: {inputEmail.Text} </br>");
            Response.Write($"Você tem {idadeDias} </br></br>");
        }

        private static string CalculaIdade(DateTime dataNascimento)
        {

            DateTime dataAtual = DateTime.Now;

            int anos = new DateTime(DateTime.Now.Subtract(dataNascimento).Ticks).Year - 1;
            DateTime anosPassados = dataNascimento.AddYears(anos);
            int meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (anosPassados.AddMonths(i) == dataAtual)
                {
                    meses += 1;
                    break;
                }
                else if (anosPassados.AddMonths(i) >= dataAtual)
                {
                    meses = i - 1;
                    break;
                }
            }

            int dias = dataAtual.Subtract(anosPassados.AddMonths(meses)).Days;
            int horas = dataAtual.Subtract(anosPassados).Hours;
            int minutos = dataAtual.Subtract(anosPassados).Minutes;
            int segundos = dataAtual.Subtract(anosPassados).Seconds;

            return $"{anos} anos {dias} dias {minutos} minutos {segundos} segundos";

        }

    }
}


