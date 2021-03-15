namespace AwesomeGym.Application.ViewModels
{
    public class AlunoItemViewModel
    {
        public AlunoItemViewModel(int id, string nomeCompleto)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
    }
}