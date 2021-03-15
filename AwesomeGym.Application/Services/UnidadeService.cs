using AwesomeGym.Application.InputModels;
using AwesomeGym.Application.ViewModels;
using AwesomeGym.Core.Entidades;
using AwesomeGym.Core.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGym.Application.Services
{
    public class UnidadeService : IUnidadeService
    {
        private readonly IUnidadeRepository _unidadeRepository;
        public UnidadeService(IUnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }

        public async Task<int> Adicionar(UnidadeInputModel unidadeInputModel)
        {
            var unidade = new Unidade(unidadeInputModel.Nome, unidadeInputModel.EnderecoCompleto);

            var id = await _unidadeRepository.Adicionar(unidade);

            return id;
        }

        public async Task<UnidadeViewModel> ObterPorId(int id)
        {
            var unidade = await _unidadeRepository.ObterPorId(id);

            if (unidade == null)
            {
                return null;
            }

            var alunosItemViewModel = unidade.Alunos.Select(a => new AlunoItemViewModel(a.Id, a.NomeCompleto)).ToList();
            var funcionariosItemViewModel = unidade.Funcionarios.Select(f => new FuncionarioItemViewModel(f.Id, f.NomeCompleto)).ToList();
            var equipamentosItemViewModel = unidade.Equipamentos.Select(e => new EquipamentoItemViewModel(e.Id, e.Nome)).ToList();

            return new UnidadeViewModel(unidade.Id, unidade.Nome, unidade.EnderecoCompleto, alunosItemViewModel, funcionariosItemViewModel, equipamentosItemViewModel);
        }

        public async Task<List<UnidadeItemViewModel>> ObterTodos()
        {
            var unidades = await _unidadeRepository.ObterTodos();

            var unidadeItemViewModelList = unidades
                .Select(u => new UnidadeItemViewModel(u.Id, u.Nome))
                .ToList();

            return unidadeItemViewModelList;
        }
    }
}
