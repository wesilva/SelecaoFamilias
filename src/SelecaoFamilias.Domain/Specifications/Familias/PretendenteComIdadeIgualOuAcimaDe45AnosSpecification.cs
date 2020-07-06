using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class PretendenteComIdadeIgualOuAcimaDe45AnosSpecification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 3;

        public void ValidarCriterio(Familia familia)
        {
            //if (familia.ObterIdadePretendente() >= 45)
            //    familia.AdicionarCriterio(Pontos);
        }
    }
}
