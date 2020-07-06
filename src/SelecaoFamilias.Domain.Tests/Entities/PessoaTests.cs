using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.Entities;
using System;
using System.Linq;

namespace SelecaoFamilias.Domain.Tests.Entities
{
    [TestClass]
    public class PessoaTests
    {
        public Pessoa Pessoa { get; set; }

        [TestMethod]
        public void PessoaConsistente_Valid_true() 
        {
            Pessoa = new Pessoa("Wellington", Enums.ETipoType.Pretendente, new DateTime(1991, 7, 23), 15);

            Assert.IsTrue(Pessoa.EhValido());
        }

        [TestMethod]
        public void PessoaNome_Valid_false()
        {
            Pessoa = new Pessoa("", Enums.ETipoType.Pretendente, DateTime.Now.AddDays(5), 15);

            Assert.IsFalse(Pessoa.EhValido());
            Assert.IsTrue(Pessoa.ValidationResult.Errors.Any(e => e.ErrorMessage == "O nome é obrigatório"));
        }
    }
}
