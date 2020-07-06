using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class RendaTotalFamiliaEntre901E1500Specification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 3;

        public void ValidarCriterio(Familia familia)
        {
            var rendaTotal = familia.ObterRendaTotal();
            //if (rendaTotal >= 901 && rendaTotal <= 1500)
            //    familia.AdicionarCriterio(Pontos);
        }
    }
}
