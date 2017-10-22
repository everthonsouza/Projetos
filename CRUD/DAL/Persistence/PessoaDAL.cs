using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    //operações com o BD
    public class PessoaDAL : Conexao //herda de conexao para ter acesso aos atributos e metodos
    {
        public void Gravar(Pessoa p)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("INSERT INTO Pessoa (Nome, Endereco, Email) values (@Nome, @Endereco, @Email)", Con);

                Cmd.Parameters.AddWithValue("@Nome", p.Nome);
                Cmd.Parameters.AddWithValue("@Endereco", p.Endereco);
                Cmd.Parameters.AddWithValue("@Email", p.Email);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o cliente..." + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Atualizar(Pessoa p)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("UPDATE Pessoa SET Nome = @Nome, Endereco = @Endereco, Email = @Email WHERE Codigo = @Codigo", Con);

                Cmd.Parameters.AddWithValue("@Nome", p.Nome);
                Cmd.Parameters.AddWithValue("Endereco", p.Endereco);
                Cmd.Parameters.AddWithValue("Email", p.Email);
                Cmd.Parameters.AddWithValue("Codigo", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o cliente..." + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void Excluir(int Codigo)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("DELETE FROM Pessoa WHERE Codigo = @Codigo", Con);

                Cmd.Parameters.AddWithValue("@Codigo", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o cliente..." + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public Pessoa BuscaPorId(int Codigo)
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Pessoa WHERE Codigo = @Codigo", Con);

                Cmd.Parameters.AddWithValue("@Codigo", Codigo);

                Dr = Cmd.ExecuteReader(); //execução da leitura

                Pessoa p = null; //criando um espaço de memória

                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public List<Pessoa> ListarPessoa()
        {
            try
            {
                abrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Pessoa", Con);

                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os clientes..." + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }

}
