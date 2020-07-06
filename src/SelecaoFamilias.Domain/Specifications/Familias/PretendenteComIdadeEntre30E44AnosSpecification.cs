using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Domain.Specifications.Familias
{
    public class PretendenteComIdadeEntre30E44AnosSpecification : ISpecification<Familia>
    {
        private int Pontos { get; set; } = 2;

        public void ValidarCriterio(Familia familia)
        {
            var idadePretendente = familia.ObterIdadePretendente();
            //if (idadePretendente >= 30 && idadePretendente <= 44)
            //    familia.AdicionarCriterio(Pontos);
        }
    }
}
