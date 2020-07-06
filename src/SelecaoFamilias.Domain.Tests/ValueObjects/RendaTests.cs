using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.Tests.ValueObjects
{
    [TestClass]
    public class RendaTests
    {
        [TestMethod]
        public void DeveRetornarErrorQuandoRendaForMenorQueZero()
        {
            var renda = new Renda(-50);
            Assert.IsTrue(renda.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoRendaForMaiorOuIgualAZero()
        {
            var renda = new Renda(10);
            Assert.IsTrue(renda.Valid);
        }
    }
}
