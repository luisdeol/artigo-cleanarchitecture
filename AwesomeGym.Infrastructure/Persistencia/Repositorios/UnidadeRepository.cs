using AwesomeGym.Core.Entidades;
using AwesomeGym.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGym.Infrastructure.Persistencia.Repositorios
{
    public class UnidadeRepository : IUnidadeRepository
    {
        private readonly List<Unidade> _unidades;
        private int _idAtual = 1;
        public UnidadeRepository()
        {
            var unidade1 = new Unidade("Unidade 1", "Rua Marombeira")
            {
                Alunos = new List<Aluno> { new Aluno("Aluno 1", "", new DateTime(1992, 1, 1)) },
                Funcionarios = new List<Funcionario> { new Funcionario("Funcionario 1", DateTime.Now) },
                Equipamentos = new List<Equipamento> { new Equipamento("Equipamento 1", "Equipamento para treino de peitoral.", DateTime.Now) }
            };

            var unidade2 = new Unidade("Unidade 2", "Rua Levanta Peso")
            {
                Alunos = new List<Aluno> { new Aluno("Aluno 2", "", new DateTime(1992, 1, 1)) },
                Funcionarios = new List<Funcionario> { new Funcionario("Funcionario 2", DateTime.Now) },
                Equipamentos = new List<Equipamento> { new Equipamento("Equipamento 2", "Equipamento para treino de peitoral.", DateTime.Now) }
            };

            var unidade3 = new Unidade("Unidade 3", "Rua Suplementar")
            {
                Alunos = new List<Aluno> { new Aluno("Aluno 3", "", new DateTime(1992, 1, 1)) },
                Funcionarios = new List<Funcionario> { new Funcionario("Funcionario 3", DateTime.Now) },
                Equipamentos = new List<Equipamento> { new Equipamento("Equipamento 3", "Equipamento para treino de peitoral.", DateTime.Now) }
            };

            unidade1.SetId(_idAtual++);
            unidade2.SetId(_idAtual++);
            unidade3.SetId(_idAtual++);

            _unidades = new List<Unidade>
            {
                unidade1,
                unidade2,
                unidade3
            };
        }

        public Task<int> Adicionar(Unidade unidade)
        {
            unidade.SetId(_idAtual++);

            _unidades.Add(unidade);

            return Task.FromResult(unidade.Id);
        }

        public Task<Unidade> ObterPorId(int id)
        {
            var unidade = _unidades.SingleOrDefault(u => u.Id == id);

            return Task.FromResult(unidade);
        }

        public async Task<List<Unidade>> ObterTodos()
        {
            return await Task.FromResult(_unidades);
        }
    }
}
