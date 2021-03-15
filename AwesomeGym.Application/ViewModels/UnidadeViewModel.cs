using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeGym.Application.ViewModels
{
    public class UnidadeViewModel
    {
        public UnidadeViewModel(int id, string nome, string enderecoCompleto, List<AlunoItemViewModel> alunos, List<FuncionarioItemViewModel> funcionarios, List<EquipamentoItemViewModel> equipamentos)
        {
            Id = id;
            Nome = nome;
            EnderecoCompleto = enderecoCompleto;
            Alunos = alunos;
            Funcionarios = funcionarios;
            Equipamentos = equipamentos;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string EnderecoCompleto { get; private set; }
        public List<AlunoItemViewModel> Alunos { get; private set; }
        public List<FuncionarioItemViewModel> Funcionarios { get; private set; }
        public List<EquipamentoItemViewModel> Equipamentos { get; private set; }
    }
}
