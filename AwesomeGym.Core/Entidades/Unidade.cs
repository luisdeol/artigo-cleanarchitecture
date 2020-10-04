using System.Collections.Generic;

namespace AwesomeGym.Core.Entidades
{
    public class Unidade
    {
        protected Unidade() { }
        public Unidade(string nome, string enderecoCompleto)
        {
            Nome = nome;
            EnderecoCompleto = enderecoCompleto;
            Alunos = new List<Aluno>();
            Funcionarios = new List<Funcionario>();
            Equipamentos = new List<Equipamento>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string EnderecoCompleto { get; private set; }
        public List<Aluno> Alunos { get; private set; }
        public List<Funcionario> Funcionarios { get; private set; }
        public List<Equipamento> Equipamentos { get; private set; }
    }
}
