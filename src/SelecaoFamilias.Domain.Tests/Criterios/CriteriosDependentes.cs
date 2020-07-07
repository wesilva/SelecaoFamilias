using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Infra.Data.Factories;
using System;

namespace SelecaoFamilias.Domain.Tests.Criterios
{
    public class CriteriosDependentes
    {
        private CriteriosDependentes()
        {
            FamiliaFactory = new FamiliaFactory();

            Status = new Status(new StatusId(0), new Descricao("Cadastro válido"), true);
        }

        private FamiliaFactory FamiliaFactory { get; }
        public Status Status { get; }
        public Familia FamiliaComDoisDependentesMenorDe18Anos
        {
            get
            {
                return GerarCenarioComDoisDependentesMenorDe18Anos();
            }
        }

        public static CriteriosDependentes GerarCenarios()
        {
            return new CriteriosDependentes();
        }
        private Familia GerarCenarioComDoisDependentesMenorDe18Anos()
        {
            var familiaComDoisDependentesMenorDe18Anos = FamiliaFactory.Criar(Status);

            FamiliaFactory.AdicionarPessoa(
                familiaComDoisDependentesMenorDe18Anos,
                new NomeCompleto("Pretendente"),
                new Idade(DateTime.Now.AddYears(-30)),
                ETipoType.Pretendente,
                new Renda(1300));

            FamiliaFactory.AdicionarPessoa(
               familiaComDoisDependentesMenorDe18Anos,
               new NomeCompleto("Conjugue"),
               new Idade(DateTime.Now.AddYears(-29)),
               ETipoType.Conjugue,
               new Renda(900));

            FamiliaFactory.AdicionarPessoa(
                familiaComDoisDependentesMenorDe18Anos,
                new NomeCompleto("Dependente 1"),
                new Idade(DateTime.Now.AddYears(-10)),
                ETipoType.Dependente,
                new Renda(0));

            FamiliaFactory.AdicionarPessoa(
                familiaComDoisDependentesMenorDe18Anos,
                new NomeCompleto("Dependente 2"),
                new Idade(DateTime.Now.AddYears(-17)),
                ETipoType.Dependente,
                new Renda(0));

            return familiaComDoisDependentesMenorDe18Anos;
        }

        public Familia FamiliaComTresDependentesMenoresDeIdade
        {
            get
            {
                return GerarCenarioComTresDependentesMenoresDeIdade();
            }
        }

        private Familia GerarCenarioComTresDependentesMenoresDeIdade()
        {
            var familiaComTresDependentesMenorDe18Anos = FamiliaFactory.Criar(Status);

            FamiliaFactory.AdicionarPessoa(
                familiaComTresDependentesMenorDe18Anos,
                new NomeCompleto("Pretendente"),
                new Idade(DateTime.Now.AddYears(-30)),
                ETipoType.Pretendente,
                new Renda(1300));

            FamiliaFactory.AdicionarPessoa(
               familiaComTresDependentesMenorDe18Anos,
               new NomeCompleto("Conjugue"),
               new Idade(DateTime.Now.AddYears(-29)),
               ETipoType.Conjugue,
               new Renda(900));

            FamiliaFactory.AdicionarPessoa(
                familiaComTresDependentesMenorDe18Anos,
                new NomeCompleto("Dependente 1"),
                new Idade(DateTime.Now.AddYears(-9)),
                ETipoType.Dependente,
                new Renda(0));

            FamiliaFactory.AdicionarPessoa(
                familiaComTresDependentesMenorDe18Anos,
                new NomeCompleto("Dependente 2"),
                new Idade(DateTime.Now.AddYears(-17)),
                ETipoType.Dependente,
                new Renda(0));

            FamiliaFactory.AdicionarPessoa(
                familiaComTresDependentesMenorDe18Anos,
                new NomeCompleto("Dependente 3"),
                new Idade(DateTime.Now.AddYears(-11)),
                ETipoType.Dependente,
                new Renda(0));

            return familiaComTresDependentesMenorDe18Anos;
        }
    }
}
