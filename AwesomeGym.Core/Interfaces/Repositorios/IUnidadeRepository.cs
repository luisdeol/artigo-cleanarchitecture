using AwesomeGym.Core.Entidades;
using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Repositorios
{
    public interface IUnidadeRepository
    {
        Task Add(Unidade unidade);
    }
}
