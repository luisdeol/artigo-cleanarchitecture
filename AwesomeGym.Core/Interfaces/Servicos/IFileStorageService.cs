using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Servicos
{
    public interface IFileStorageService
    {
        Task AddFile(byte[] content, string fileName);
    }
}
