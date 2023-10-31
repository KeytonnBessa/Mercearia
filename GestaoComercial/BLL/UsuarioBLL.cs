using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        public void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (string.IsNullOrEmpty(_usuario.Nome))
                throw new Exception("Informe o nome do usuário.");
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação de senha não são iguais.");
        }
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);

            new UsuarioDAL().Inserir(_usuario);
        }

        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);
            new UsuarioDAL().Alterar(_usuario);

        }
        public void Excluir(int _id)
        {
            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuarioDAL().BuscarPorId(_id);
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().buscarPorNome(_nome);
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().buscarPorNomeUsuario(_nomeUsuario);
        }

        public void Autenticar(string _nomeUsuario, string _senha)
        {
            Usuario usuario = new UsuarioDAL().buscarPorNomeUsuario(_nomeUsuario);
            if(usuario.Senha != _senha)
            {
                throw new Exception("Usuário ou senha incorreta");
            }
        } 
    }
}
