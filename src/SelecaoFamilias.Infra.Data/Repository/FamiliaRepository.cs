using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace SelecaoFamilias.Infra.Data.Repository
{
    public class FamiliaRepository : Repository<Familia>, IFamiliaRepository
    {
        private readonly SelecaoFamiliaContext _selecaoFamiliaContext;
        public FamiliaRepository(SelecaoFamiliaContext selecaoFamiliaContext) : base(selecaoFamiliaContext)
        {
            _selecaoFamiliaContext = selecaoFamiliaContext;
        }
        public void AdicionarFamilia(Familia familia)
        {
            _selecaoFamiliaContext.Familias.Add(familia);
            _selecaoFamiliaContext.SaveChanges();
        }

        public IEnumerable<Familia> ObterFamiliasComCadastroValido()
        {
            return _selecaoFamiliaContext.Familias.Where(x => x.Status.StatusValido).ToList();
        }

        public Status ObterStatus(int id)
        {
           return _selecaoFamiliaContext.Status.FirstOrDefault(x => x.Id.Id == id);
        }
    }
}
