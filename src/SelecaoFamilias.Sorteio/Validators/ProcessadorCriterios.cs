using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Sorteio.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SelecaoFamilias.Sorteio.Validators
{
    public class ProcessadorCriterios : IProcessadorCriterios
    {
        public ICollection<ICriterio> CriteriosAtendidos { get; set; }
        public ProcessadorCriterios()
        {
            CriteriosAtendidos = new Collection<ICriterio>();
        }

        public IEnumerable<ICriterio> ObterCriteriosAtendidos(Familia familia)
        {
            AdicionarCriterio(new ValidadorCriteriosDependentes(familia).ObterCriterio());
            AdicionarCriterio(new ValidadorCriteriosIdadePretendente(familia).ObterCriterio());
            AdicionarCriterio(new ValidadorCriteriosRendaFamiliar(familia).ObterCriterio());

            return CriteriosAtendidos;
        }

        private void AdicionarCriterio(ICriterio criterio)
        {
            if (criterio != null)
                CriteriosAtendidos.Add(criterio);
        }
    }
}
