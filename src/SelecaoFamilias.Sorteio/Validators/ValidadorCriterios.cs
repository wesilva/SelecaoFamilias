using SelecaoFamilias.Domain.Core.Interfaces;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Validators
{
    public abstract class ValidadorCriterios
    {
        protected IList<ICriterio> Criterios { get; set; }

        public ICriterio ObterCriterio()
        {
            foreach (var criteiro in Criterios)
            {
                if (criteiro.EhAtendido())
                    return criteiro;
            }
            return null;
        }
    }
}
