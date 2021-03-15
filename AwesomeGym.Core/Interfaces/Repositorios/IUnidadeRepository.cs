using AwesomeGym.Core.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Repositorios
{
    public interface IUnidadeRepository
    {
        Task<int> Adicionar(Unidade unidade);
        Task<List<Unidade>> ObterTodos();
        Task<Unidade> ObterPorId(int id);
    }
}
