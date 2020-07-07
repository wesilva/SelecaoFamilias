using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Interfaces.Repository;
using System.Collections.Generic;

namespace SelecaoFamilias.Domain.Interfaces.Repository
{
    public interface IFamiliaRepository : IRepository<Familia>
    {
        void AdicionarFamilia(Familia familia);
        IEnumerable<Familia> ObterFamiliasComCadastroValido();
        Status ObterStatus(int id);
    }
}