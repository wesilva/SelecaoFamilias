using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Sorteio.Criterios.Dependentes;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Validators
{
    public class ValidadorCriteriosDependentes : ValidadorCriterios
    {
        public ValidadorCriteriosDependentes(Familia familia)
        {
            var quantidadeDependentes = familia.ObterQuantidadeDeDependentesMenorDe18Anos();

            Criterios = new List<ICriterio>()
            {
                new CriterioFamiliasCom1Ou2Dependentes(quantidadeDependentes),
                new CriterioFamiliasCom3OuMaisDependentes(quantidadeDependentes)
            };
        }
    }
}
