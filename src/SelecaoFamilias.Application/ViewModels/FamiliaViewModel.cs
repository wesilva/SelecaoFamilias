using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelecaoFamilias.Application.ViewModels
{
    public class FamiliaViewModel
    {
        [Required]
        public int StatusId { get; set; }
        public IEnumerable<PessoaViewModel> Pessoas { get; set; }
    }
}
