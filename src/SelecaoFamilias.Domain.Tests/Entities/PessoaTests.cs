using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.Tests.Entities
{
    [TestClass]
    public class PessoaTests
    {
        private readonly EntityId _idFamilia;
        private readonly NomeCompleto _nome;
        private readonly Renda _renda;
        public PessoaTests()
        {
            _idFamilia = new EntityId(Guid.NewGuid());
            _nome = new NomeCompleto("Wellington");
            _renda = new Renda(0);
        }

        [TestMethod]
        public void DeveRetornarErroQuandoPessoaForMenorDe18Anos() 
        {
            var idade = new Idade(DateTime.Now.AddYears(-17));
            var pessoa = new Pessoa(_idFamilia, _nome, ETipoType.Pretendente, idade, _renda);

            Assert.IsTrue(pessoa.EhMenorDe18Anos());
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoPessoaForMaiorDe18Anos()
        {
            var idade = new Idade(DateTime.Now.AddYears(-18));
            var pessoa = new Pessoa(_idFamilia, _nome, ETipoType.Pretendente, idade, _renda);

            Assert.IsFalse(pessoa.EhMenorDe18Anos());
        }
    }
}
