using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.IdadePretendente
{
    public class CriterioPretendenteComIdadeEntre30E44Anos : CriterioIdadePretendente
    {
        public override Pontuacao Pontuacao => Pontuacao.Dois();

        public CriterioPretendenteComIdadeEntre30E44Anos(Idade idade)
            : base(idade, idade => idade.ObterIdade() >= 30 && idade.ObterIdade() <= 44)
        { }
    }
   
}
