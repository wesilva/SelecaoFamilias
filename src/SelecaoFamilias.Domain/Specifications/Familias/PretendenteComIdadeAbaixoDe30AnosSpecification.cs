using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class PretendenteComIdadeAbaixoDe30AnosSpecification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 1;

        public void ValidarCriterio(Familia familia)
        {
            if (familia.ObterIdadePretendente() < 30)
                familia.AdicionarCriterio(Pontos);
        }
    }
}
