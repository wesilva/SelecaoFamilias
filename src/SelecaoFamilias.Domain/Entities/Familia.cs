using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Enums;
using System.Collections.Generic;
using FluentValidation;
using System.Linq;

namespace SelecaoFamilias.Domain.Entities
{
    public class Familia : Entity<Familia>
    {
        public int PontuacaoTotal { get; private set; }
        public int QuantidadeCriteriosAtendidos { get; private set; }

        private IList<Pessoa> _pessoas;
        public Familia(EStatusType status)
        {
            Status = status;
            _pessoas = new List<Pessoa>();
        }

        public EStatusType Status { get; private set; }
        public IReadOnlyCollection<Pessoa> Pessoas { get { return _pessoas.ToList(); } }

        private Familia() {}

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            if (!ValidarPessoa(pessoa)) return;
            _pessoas.Add(pessoa);
        }

        public void AdicionarCriterio(int pontos)
        {
            if(pontos > 0)
            {
                PontuacaoTotal += pontos;
                QuantidadeCriteriosAtendidos++;
            }
        }

        public decimal ObterRendaTotal()
        {
           return _pessoas.Select(x => x.Valor).Sum();
        }

        public int ObterIdadePretendente()
        {
            return _pessoas.FirstOrDefault(x => x.EhPretendente()).ObterIdade();
        }

        public int ObterQuantidadeDeDependentesMenorDe18Anos()
        {
            return _pessoas.Count(x => x.EhDependente() && x.EhMenorDe18Anos());
        }

        private bool ValidarPessoa(Pessoa pessoa)
        {
            if (pessoa.EhValido()) return true;

            foreach (var error in pessoa.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
            return false;
        }

        private void Validar()
        {
            ValidarSePossuiPretendente();

            ValidationResult = Validate(this);
        }

        private void ValidarSePossuiPretendente()
        {
            RuleFor(f => f._pessoas.Count(p => p.EhPretendente()))
                .Equal(0)
                .WithMessage("A família precisa ter um pretendente");    
        }
    }
}
