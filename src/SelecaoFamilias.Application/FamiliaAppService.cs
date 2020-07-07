using SelecaoFamilias.Application.Interfaces;
using SelecaoFamilias.Application.ViewModels;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.Interfaces;

namespace SelecaoFamilias.Application
{
    public class FamiliaAppService : IFamiliaAppService
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IFamiliaFactory _familiaFactory;
        private readonly ICalculoDePontosDosCriteriosAppService _calculoDePontosDosCriteriosAppService;

        public FamiliaAppService(
            IFamiliaRepository familiaRepository,
            IFamiliaFactory familiaFactory,
            ICalculoDePontosDosCriteriosAppService calculoDePontosDosCriteriosAppService)
        {
            _familiaRepository = familiaRepository;
            _familiaFactory = familiaFactory;
            _calculoDePontosDosCriteriosAppService = calculoDePontosDosCriteriosAppService;
        }

        public ResultViewModel CadastrarFamilia(FamiliaViewModel familiaViewModel)
        {
            var resultViewModel = new ResultViewModel();
            var status = _familiaRepository.ObterStatus(familiaViewModel.StatusId);
            var familia = _familiaFactory.Criar(status);

            foreach (var pessoa in familiaViewModel.Pessoas)
            {
                familia.AdicionarPessoa(
                    new NomeCompleto(pessoa.Nome),
                    pessoa.Tipo,
                    new Idade(pessoa.DataNascimento),
                    pessoa.Renda.HasValue ? new Renda(pessoa.Renda.Value) : new Renda(0));
            }
            if (!familia.EhValido())
            {
                foreach (var notification in familia.Notifications)
                {
                    resultViewModel.AdicionarMensagem(notification.Message);
                }
                return resultViewModel;
            }
            _familiaRepository.Adicionar(familia);

            if (familia.Status.StatusValido)
                _calculoDePontosDosCriteriosAppService.CalcularPontosDeFamiliasAptas(familia);

            return resultViewModel;
        }
    }
}
