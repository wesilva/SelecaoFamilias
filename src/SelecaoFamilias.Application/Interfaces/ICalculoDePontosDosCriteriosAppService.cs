using SelecaoFamilias.Application.ViewModels;
using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Application.Interfaces
{
    public interface ICalculoDePontosDosCriteriosAppService
    {
        void CalcularPontosDeFamiliasAptas(Familia familia);
    }
}
