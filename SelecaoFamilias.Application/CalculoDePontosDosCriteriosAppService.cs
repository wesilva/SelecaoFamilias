using SelecaoFamilias.Application.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Sorteio.Entities;
using SelecaoFamilias.Sorteio.Interfaces;

namespace SelecaoFamilias.Application
{
    public class CalculoDePontosDosCriteriosAppService : ICalculoDePontosDosCriteriosAppService
    {
        private readonly IProcessadorCriterios _processadorCriterios;
        private readonly IFamiliaAptaRepository _familiaAptaRepository;
        public CalculoDePontosDosCriteriosAppService(
            IProcessadorCriterios processadorCriterios,
            IFamiliaAptaRepository familiaAptaRepository)
        {
            _processadorCriterios = processadorCriterios;
            _familiaAptaRepository = familiaAptaRepository;
        }
        public void CalcularPontosDeFamiliasAptas(Familia familia)
        {
            var criteriosAtendidos =_processadorCriterios.ObterCriteriosAtendidos(familia);

            var familiaApta = new FamiliaApta(familia.Id, criteriosAtendidos);

            _familiaAptaRepository.Salvar(familiaApta);
        }
    }
}
