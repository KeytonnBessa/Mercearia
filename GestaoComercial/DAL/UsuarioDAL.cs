using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection("User ID=SA;Initial Catalog=Mercearia,Data Source=.\\sqlexpress2019;Password=Senailab02");
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)
                                    VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                
                cn.Open();
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("");
            }

        }

        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(Usuario _usuario)
        {

        }
        public List<Usuario> BuscarTodos(int _id)
        {
            throw new NotImplementedException();
        }

    }
}
