using AwesomeGym.Core.DTOs;
using AwesomeGym.Core.Entidades;

namespace AwesomeGym.Core.Interfaces.Servicos
{
    public interface IInscricaoService
    {
        ResultadoInscricaoDTO Realizar(Aluno aluno, Unidade unidade, TurmaAtividade turmaAtividade);
    }
}
