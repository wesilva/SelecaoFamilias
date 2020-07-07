using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.RendaFamiliar
{
    public class RendaTotalFamiliaEntre901E1500 : CriterioRendaFamiliar
    {
        public override Pontuacao Pontuacao => Pontuacao.Tres();

        public RendaTotalFamiliaEntre901E1500(Renda renda)
             : base(renda, renda => renda.Valor >= 901 && renda.Valor <= 1500)
        { }
    }
}
