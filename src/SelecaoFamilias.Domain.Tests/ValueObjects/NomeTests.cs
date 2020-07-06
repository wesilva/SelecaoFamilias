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
            var renda = new Nome(nome);
            Assert.IsTrue(renda.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoNomeNaoForNuloOuVazio()
        {
            var renda = new Nome("Wellington");
            Assert.IsTrue(renda.Valid);
        }
    }
}
