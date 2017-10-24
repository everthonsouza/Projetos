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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                Pessoa p = d.BuscaPorId(cod);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                    lblMensagem.Text = null;
                } else
                {
                    lblMensagem.Text = "Cliente não localizado!";
                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(txtCodigo.Text);
                PessoaDAL d = new PessoaDAL();
                d.Excluir(cod);
                pnlDados.Visible = false;
                lblMensagem.Text = "Cliente excluido com sucesso!";

                txtCodigo.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                string email = txtEmail.Text;

                Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

                if (rg.IsMatch(email))
                {
                    PessoaDAL d = new PessoaDAL();
                    d.Atualizar(p);
                    pnlDados.Visible = false;
                    lblMensagem.Text = "Cliente atualizado com sucesso!";

                    txtCodigo.Text = string.Empty;
                }
                else
                {
                    pnlDados.Visible = true;
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