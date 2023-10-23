using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Cliente(Nome, Fone)
                                    VALUES(@Nome, @Fone)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuario no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Usuario
                SET Nome = @Nome, Fone = @Fone
                WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Fone", _cliente.Fone);
                cmd.Parameters.AddWithValue("@Id", _cliente.Id);


                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuario no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Cliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o usuario no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarTodos(int _id)
        {
            throw new NotImplementedException();
        }


    }
}
