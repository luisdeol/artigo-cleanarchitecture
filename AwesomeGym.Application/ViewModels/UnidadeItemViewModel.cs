namespace AwesomeGym.Application.ViewModels
{
    public class UnidadeItemViewModel
    {
        public UnidadeItemViewModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
