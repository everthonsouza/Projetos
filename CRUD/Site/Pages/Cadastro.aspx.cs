using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Text.RegularExpressions;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                string email = txtEmail.Text;

                Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

                if (rg.IsMatch(email))
                {
                    PessoaDAL d = new PessoaDAL();
                    d.Gravar(p);

                    lblMensagem.Text = "Cliente cadastrado com sucesso";

                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                }
                else
                {
                    lblMensagem.Text = "E-mail inválido";
                }


            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
    }
}