using SelecaoFamilias.Application.ViewModels;

namespace SelecaoFamilias.Application.Interfaces
{
    public interface IFamiliaAppService
    {
        ResultViewModel CadastrarFamilia(FamiliaViewModel familiaViewModel);
    }
}
