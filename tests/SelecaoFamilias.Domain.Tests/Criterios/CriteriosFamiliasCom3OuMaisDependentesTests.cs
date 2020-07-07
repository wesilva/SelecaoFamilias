using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelecaoFamilias.Sorteio.Criterios.Dependentes;

namespace SelecaoFamilias.Domain.Tests.Criterios
{
    [TestClass]
    public class CriteriosFamiliasCom3OuMaisDependentesTests
    {
        private readonly CriteriosDependentes _criteriosPendentes;
        public CriteriosFamiliasCom3OuMaisDependentesTests()
        {
            _criteriosPendentes = CriteriosDependentes.GerarCenarios();
        }

        [TestMethod]
        public void DeveRetornarErroQuandoQuantidadeDeDependentesMenorDe18AnosForMenorQue3()
        {
            var familia = _criteriosPendentes.FamiliaComDoisDependentesMenorDe18Anos;

            var criterio = new CriterioFamiliasCom3OuMaisDependentes(familia.ObterQuantidadeDeDependentesMenorDe18Anos());

            Assert.IsFalse(criterio.EhAtendido());
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoQuantidadeDeDependentesForIgualOuMaiorQue3()
        {
            var familia = _criteriosPendentes.FamiliaComTresDependentesMenoresDeIdade;

            var criterio = new CriterioFamiliasCom3OuMaisDependentes(familia.ObterQuantidadeDeDependentesMenorDe18Anos());

            Assert.IsTrue(criterio.EhAtendido());
        }
    }
}
