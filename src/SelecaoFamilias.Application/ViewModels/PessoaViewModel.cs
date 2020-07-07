using SelecaoFamilias.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelecaoFamilias.Application.ViewModels
{
    public class PessoaViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public ETipoType Tipo { get; set; }

        public decimal?  Renda { get; set; }
    }
}
