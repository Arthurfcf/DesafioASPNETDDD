using ProjetoDDD.DOMAIN.Entity;
using ProjetoDDD.DOMAIN.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infra.Data.Repository
{
    class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarProNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }

        public Usuario BuscaUsuario(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> Listagem()
        {
            throw new System.NotImplementedException();
        }
    }
}
