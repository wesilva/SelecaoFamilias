using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Infra.Data.Context;
using SelecaoFamilias.Sorteio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SelecaoFamilias.Infra.Data.Repository
{
    public class FamiliaAptaRepository : Repository<FamiliaApta>, IFamiliaAptaRepository
    {
        private readonly SelecaoFamiliaContext _selecaoFamiliaContext;
        public FamiliaAptaRepository(SelecaoFamiliaContext selecaoFamiliaContext) : base(selecaoFamiliaContext)
        {
            _selecaoFamiliaContext = selecaoFamiliaContext;
        }

        public void Salvar(FamiliaApta familiaApta)
        {
            _selecaoFamiliaContext.FamiliasAptas.Add(familiaApta);
            _selecaoFamiliaContext.SaveChanges();
        }

        public IEnumerable<FamiliaApta> ObterFamiliasAptasOrdenadasPorPontuacao()
        {
           return _selecaoFamiliaContext.FamiliasAptas.OrderByDescending(r => r.PontuacaoTotal).ToList();
        }
    }
}
