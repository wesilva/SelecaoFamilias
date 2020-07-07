using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.RendaFamiliar
{
    public class RendaTotalFamiliaEntre1501E2000 : CriterioRendaFamiliar
    {
        public override Pontuacao Pontuacao => Pontuacao.Um();

        public RendaTotalFamiliaEntre1501E2000(Renda renda)
             : base(renda, renda => renda.Valor > 1500 && renda.Valor <= 2000)
        { }
    }
}
