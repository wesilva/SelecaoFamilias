using SelecaoFamilias.Sorteio.Entities;
using System.Collections.Generic;

namespace SelecaoFamilias.Domain.Interfaces.Repository
{
    public interface IFamiliaAptaRepository : IRepository<FamiliaApta>
    {
        void Salvar(FamiliaApta familiaApta);
        IEnumerable<FamiliaApta> ObterFamiliasAptasOrdenadasPorPontuacao();
    }
}