using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Interfaces
{
    public interface IProcessadorCriterios
    {
        IEnumerable<ICriterio> ObterCriteriosAtendidos(Familia familia);
    }
}
