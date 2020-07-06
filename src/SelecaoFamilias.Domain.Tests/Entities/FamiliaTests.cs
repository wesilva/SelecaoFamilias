using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using System;
using System.Linq;

namespace SelecaoFamilias.Domain.Tests.Entities
{
    [TestClass]
    public class FamiliaTests
    {
        private readonly Familia _familia;
        private readonly Nome _nome;
        private readonly Idade _idade;
        private readonly Renda _renda;
        private readonly Status _status;

        public FamiliaTests()
        {
            _status = new Status(1, "Cadastro Válido", true);
            _familia = new Familia(_status);
            _nome = new Nome("Wellington");
            _idade = new Idade(DateTime.Now.AddYears(-28));
            _renda = new Renda(0);
            _familia.AdicionarPessoa(_nome, ETipoType.Dependente, _idade, _renda);
        }
        public Pessoa Pessoa { get; set; }

        [TestMethod]
        public void DeveRetornarErroQuandoFamiliaNaoTemPretendenteOuTemMaisDeUm()
        {
            _familia.AdicionarPessoa(_nome, ETipoType.Conjugue, _idade, _renda);
            Assert.IsFalse(_familia.EhValido());
            Assert.IsTrue(_familia.Notifications.Count == 1);
            Assert.IsTrue(_familia.Notifications.Any(n => n.Message == "Deve ter somente 1 pretendente"));
        }

        [TestMethod]
        public void DeveRetornarErroQuandoFamiliaNaoTemConjugueOuTemMaisDeUm()
        {
            _familia.AdicionarPessoa(_nome, ETipoType.Pretendente, _idade, _renda);
            Assert.IsFalse(_familia.EhValido());
            Assert.IsTrue(_familia.Notifications.Count == 1);
            Assert.IsTrue(_familia.Notifications.Any(n => n.Message == "Deve ter somente 1 conjugue"));
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoFamiliaTemSomenteUmPretendenteEUmConjugue()
        {
            _familia.AdicionarPessoa(_nome, ETipoType.Pretendente, _idade, _renda);
            _familia.AdicionarPessoa(_nome, ETipoType.Conjugue, _idade, _renda);
            Assert.IsTrue(_familia.EhValido());
        }
    }
}
