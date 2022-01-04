using ProjetoDDD.DOMAIN.Entity;
using ProjetoDDD.DOMAIN.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repository
{

    public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public Funcionario BuscaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Funcionario> Listagem()
        {
            throw new NotImplementedException();
        }
    }
}
