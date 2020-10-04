using System;

namespace AwesomeGym.Core.Entidades
{
    public class TurmaAtividade
    {
        protected TurmaAtividade() { }
        public TurmaAtividade(string nome, string descricao, DateTime dataInicio, TimeSpan horarioInicio, TimeSpan horarioFim, bool ativa)
        {
            Nome = nome;
            Descricao = descricao;
            DataInicio = dataInicio;
            HorarioInicio = horarioInicio;
            HorarioFim = horarioFim;
            Ativa = ativa;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        // Não vou especificar dia da semana nesse exemplo! Apenas o horário.
        public TimeSpan HorarioInicio { get; private set; }
        public TimeSpan HorarioFim { get; private set; }
        public bool Ativa { get; private set; }
    }
}
