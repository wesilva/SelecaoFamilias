using SelecaoFamilias.Application.ViewModels;
using SelecaoFamilias.Domain.Entities;

namespace SelecaoFamilias.Application.Interfaces
{
    interface ICalculoDePontosDosCriteriosAppService
    {
        void CalcularPontosDeFamiliasAptas(Familia familia);
    }
}
