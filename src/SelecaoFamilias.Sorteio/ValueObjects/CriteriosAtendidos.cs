using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Core.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace SelecaoFamilias.Sorteio.ValueObjects
{
    public class CriteriosAtendidos : ValueObject
    {
        public Pontuacao PontuacaoTotal { get; private set; }
        public int QuantidadeCriteriosAtendidos { get; private set; }

        protected CriteriosAtendidos() {}
        public CriteriosAtendidos(IEnumerable<ICriterio> criteriosAtendidos)
        {
            QuantidadeCriteriosAtendidos = criteriosAtendidos.Count();
            PontuacaoTotal = criteriosAtendidos.Select(criterio => criterio.Pontuacao)
                .Aggregate((pontuacaoTotal, pontuacaoAtual) => pontuacaoTotal + pontuacaoAtual);
        }
    }
}
