using AwesomeGym.Core.Enums;
using System;

namespace AwesomeGym.Core.Entidades
{
    public class Aluno
    {
        protected Aluno() { }
        public Aluno(string nomeCompleto, string observacoesMedicas, DateTime dataNascimento, StatusAlunoEnum status)
        {
            NomeCompleto = nomeCompleto;
            ObservacoesMedicas = observacoesMedicas;
            DataNascimento = dataNascimento;
            Status = status;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string ObservacoesMedicas { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }
    }
}
