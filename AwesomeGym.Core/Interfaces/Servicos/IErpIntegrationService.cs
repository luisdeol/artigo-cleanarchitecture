using AwesomeGym.Core.DTOs;
using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Servicos
{
    public interface IErpIntegrationService
    {
        Task AdicionarPessoa(AdicionarPessoaErpDTO pessoa);
    }
}
