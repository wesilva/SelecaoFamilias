using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Interfaces
{
    interface IProcessadorCriterios
    {
        IEnumerable<ICriterio> ObterCriteriosAtendidos(Familia familia);
    }
}
