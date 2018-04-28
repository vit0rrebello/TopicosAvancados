using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formulario
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtNome.Text;
            lblRg.Text = TextRg.Text;
            lblCpf.Text = TextCpf.Text;
            lblLinguagem.Text = TextLinguagem.Text;
            lblAdj.Text = TextAdj.Text;
            lblCidade.Text = TextCidade.Text;
            lblDia.Text = TextDia.Text;
            lblAno.Text = TextAno.Text;
            lblIdade.Text = TextIdade.Text;

        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            ////declarando a variável do tipo StreamWriter para 
            //abrir ou criar um arquivo para escrita
            StreamWriter x;

            //Colocando o endereço físico (caminho do arquivo texto) 
            string Caminho = "C:\\Users\\msndu\\Documents\\Formulario\\Formulario.txt";

            //usando o metodo e abrindo o arquivo texto
            x = File.AppendText(Caminho);

            //continuando escrevendo neste arquivo
            //escrevendo a partir da ultima linha 
            x.WriteLine("Carta <br><br> Eu, " +lblNome+ " portador do RG: " +lblRg+ " , CPF: " +lblCpf+ "<br> Adoro estudar" +lblLinguagem+ " porque é uma linguagem " +lblAdj+". <br><br><br>" +lblCidade+ ", " +lblDia+ " de " +lblAno+"." + "<br>" + "*Declado ser " +lblIdade+ "de idade.");
      
            x.Close();

        }
    }
}