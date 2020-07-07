using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.Tests.ValueObjects
{
    [TestClass]
    public class IdadeTests
    {
        [TestMethod]
        public void DeveRetornarErrorQuandoDataMaiorQueDataAtual()
        {
            var idade = new Idade(DateTime.Now.AddDays(2));
            Assert.IsTrue(idade.Invalid);
        }

        [TestMethod]
        public void DeveRetornarErrorQuandoDataForIgualAMinDate()
        {
            var idade = new Idade(DateTime.MinValue);
            Assert.IsTrue(idade.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoDataForValida()
        {
            var idade = new Idade(DateTime.Now.AddYears(-10));
            Assert.IsTrue(idade.Valid);
        }
    }
}
