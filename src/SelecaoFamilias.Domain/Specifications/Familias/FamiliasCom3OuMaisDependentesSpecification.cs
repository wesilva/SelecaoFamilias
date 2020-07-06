using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class FamiliasCom3OuMaisDependentesSpecification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 3;

        public void ValidarCriterio(Familia familia)
        {
            if (familia.ObterQuantidadeDeDependentesMenorDe18Anos() >= 3)
                familia.AdicionarCriterio(Pontos);
        }
    }
}
