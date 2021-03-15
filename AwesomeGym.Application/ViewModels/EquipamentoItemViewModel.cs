namespace AwesomeGym.Application.ViewModels
{
    public class EquipamentoItemViewModel
    {
        public EquipamentoItemViewModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}