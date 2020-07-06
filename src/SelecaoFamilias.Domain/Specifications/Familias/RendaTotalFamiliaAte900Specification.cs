using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class RendaTotalFamiliaAte900Specification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 5;

        public void ValidarCriterio(Familia familia)
        {
            if (familia.ObterRendaTotal() <= 900)
                familia.AdicionarCriterio(Pontos);
        }
    }
}
