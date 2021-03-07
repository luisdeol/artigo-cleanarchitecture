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

        public async Task Adicionar(UnidadeInputModel unidadeInputModel)
        {
            var unidade = new Unidade(unidadeInputModel.Nome, unidadeInputModel.EnderecoCompleto);

            await _unidadeRepository.Adicionar(unidade);
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
