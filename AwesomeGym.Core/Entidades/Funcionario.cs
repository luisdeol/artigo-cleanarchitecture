using AwesomeGym.Core.Enums;
using System;

namespace AwesomeGym.Core.Entidades
{
    public class Funcionario
    {
        protected Funcionario() { }
        public Funcionario(string nomeCompleto, DateTime dataInicio)
        {
            NomeCompleto = nomeCompleto;
            DataInicio = dataInicio;
            CadastradoEm = DateTime.Now;
            Status = StatusFuncionarioEnum.Ativo;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public DateTime CadastradoEm { get; private set; }
        public StatusFuncionarioEnum Status { get; private set; }
    }
}
