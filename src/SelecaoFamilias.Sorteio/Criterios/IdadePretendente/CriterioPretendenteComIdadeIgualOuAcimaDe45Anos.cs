using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.IdadePretendente
{
    public class CriterioPretendenteComIdadeIgualOuAcimaDe45Anos : CriterioIdadePretendente
    {
        public override Pontuacao Pontuacao => Pontuacao.Tres();

        public CriterioPretendenteComIdadeIgualOuAcimaDe45Anos(Idade idade)
            : base(idade, idade => idade.ObterIdade() >= 45)
        { }
    }
}
