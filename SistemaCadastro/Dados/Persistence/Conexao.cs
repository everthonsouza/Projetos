using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Persistence
{
    public class Conexao
    {
        //atributos
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void abrirConexao()
        {
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-J868SSLA;Initial Catalog=teste;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void fecharConexao()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
