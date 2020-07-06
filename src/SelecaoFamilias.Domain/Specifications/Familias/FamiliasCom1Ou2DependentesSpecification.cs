using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class FamiliasCom1Ou2DependentesSpecification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 2;

        public void ValidarCriterio(Familia familia)
        {
            var quantidadeDependentesMenorDe18Anos = familia.ObterQuantidadeDeDependentesMenorDe18Anos();
            if (quantidadeDependentesMenorDe18Anos > 0 && quantidadeDependentesMenorDe18Anos < 3)
                familia.AdicionarCriterio(Pontos);
        }
    }
}
