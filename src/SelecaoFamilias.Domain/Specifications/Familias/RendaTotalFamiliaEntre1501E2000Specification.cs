using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class RendaTotalFamiliaEntre1501E2000Specification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 1;

        public void ValidarCriterio(Familia familia)
        {
            var rendaTotal = familia.ObterRendaTotal();
            if (rendaTotal >= 1501 && rendaTotal <= 2000)
                familia.AdicionarCriterio(Pontos);
        }
    }
}
