using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.ValueObjects;

namespace SelecaoFamilias.Domain.Tests.ValueObjects
{
    [TestClass]
    public class NomeTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void DeveRetornarErrorQuandoNomeForNuloOuVazio(string nome)
        {
            var renda = new NomeCompleto(nome);
            Assert.IsTrue(renda.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoNomeNaoForNuloOuVazio()
        {
            var renda = new NomeCompleto("Wellington");
            Assert.IsTrue(renda.Valid);
        }
    }
}
