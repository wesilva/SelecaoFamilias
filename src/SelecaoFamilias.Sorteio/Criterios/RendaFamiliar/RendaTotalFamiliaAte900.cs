using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.RendaFamiliar
{
    public class RendaTotalFamiliaAte900 : CriterioRendaFamiliar
    {
        public override Pontuacao Pontuacao => Pontuacao.Cinco();

        public RendaTotalFamiliaAte900(Renda renda)
             : base(renda, renda => renda.Valor <= 900)
        { }
    }
}
