using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Sorteio.Criterios.IdadePretendente;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Validators
{
    public class ValidadorCriteriosIdadePretendente : ValidadorCriterios
    {
        public ValidadorCriteriosIdadePretendente(Familia familia)
        {
            var idadePretendente = familia.ObterIdadePretendente();

            Criterios = new List<ICriterio>()
            {
                new CriterioPretendenteComIdadeAbaixoDe30Anos(idadePretendente),
                new CriterioPretendenteComIdadeEntre30E44Anos(idadePretendente),
                new CriterioPretendenteComIdadeIgualOuAcimaDe45Anos(idadePretendente)
            };
        }
    }
}
