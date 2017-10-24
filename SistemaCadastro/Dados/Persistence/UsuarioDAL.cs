using Dados.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Persistence
{
    public class UsuarioDAL : Conexao //herda de conexao para ter acesso aos atributos e metodos
    {
        public void GravarUsuario(Usuario u)
        {
            try
            {
                abrirConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
