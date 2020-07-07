using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Sorteio.Criterios.RendaFamiliar;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Validators
{
    public class ValidadorCriteriosRendaFamiliar : ValidadorCriterios
    {
        public ValidadorCriteriosRendaFamiliar(Familia familia)
        {
            var rendaTotal = familia.ObterRendaTotal();

            Criterios = new List<ICriterio>()
            {
                new RendaTotalFamiliaAte900(rendaTotal),
                new RendaTotalFamiliaEntre1501E2000(rendaTotal),
                new RendaTotalFamiliaEntre901E1500(rendaTotal)
            };
        }
    }
}
