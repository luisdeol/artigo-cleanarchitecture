namespace AwesomeGym.Core.DTOs
{
    public class ResultadoInscricaoDTO
    {
        public ResultadoInscricaoDTO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
    }
}
