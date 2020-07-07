using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.IdadePretendente
{
    public class CriterioPretendenteComIdadeAbaixoDe30Anos : CriterioIdadePretendente
    {
        public override Pontuacao Pontuacao => Pontuacao.Um();

        public CriterioPretendenteComIdadeAbaixoDe30Anos(Idade idade)
            : base(idade, idade => idade.ObterIdade() < 30)
        { }
    }
}
