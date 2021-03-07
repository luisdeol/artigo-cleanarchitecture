using AwesomeGym.Core.Entidades;
using AwesomeGym.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGym.Infrastructure.Persistencia.Repositorios
{
    public class UnidadeRepository : IUnidadeRepository
    {
        public Task Adicionar(Unidade unidade)
        {
            throw new NotImplementedException();
        }

        public Task<List<Unidade>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
