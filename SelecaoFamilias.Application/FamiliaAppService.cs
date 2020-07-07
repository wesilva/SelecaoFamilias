using Flunt.Notifications;
using SelecaoFamilias.Application.Interfaces;
using SelecaoFamilias.Application.ViewModels;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.Interfaces;

namespace SelecaoFamilias.Application
{
    public class FamiliaAppService : Notifiable, IFamiliaAppService
    {
        private readonly IFamiliaRepository _familiaRepository;
        private readonly IFamiliaFactory _familiaFactory;

        public FamiliaAppService(
            IFamiliaRepository familiaRepository,
            IFamiliaFactory familiaFactory)
        {
            _familiaRepository = familiaRepository;
            _familiaFactory = familiaFactory;
        }

        public void CadastrarFamilia(FamiliaViewModel familiaViewModel)
        {
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
                AddNotifications(familia.Notifications);
                return;
            }
            _familiaRepository.Adicionar(familia);

            //if (familia.Status.StatusValido)
            //    await _calculoDePontosDosCriteriosAtendidos.Executar(familia);
        }
    }
}
