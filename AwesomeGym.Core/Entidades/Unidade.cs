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
        public List<Aluno> Alunos { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Equipamento> Equipamentos { get; set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
