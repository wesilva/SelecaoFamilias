using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Enums;
using FluentValidation;
using System;

namespace SelecaoFamilias.Domain.Entities
{
    public class Pessoa : Entity<Pessoa>
    {
        public Pessoa(string nome, ETipoType tipo, DateTime dataNascimento, decimal valor)
        {
            Nome = nome;
            Tipo = tipo;
            DataNascimento = dataNascimento;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public ETipoType Tipo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Valor { get; private set; }

        private Pessoa() { }

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        public bool EhPretendente()
        {
            return Tipo == ETipoType.Pretendente;
        }

        public bool EhDependente()
        {
            return Tipo == ETipoType.Dependente;
        }

        public bool EhMenorDe18Anos()
        {
            return DataNascimento > DateTime.Now.AddYears(-18);
        }

        public int ObterIdade()
        {
            var today = DateTime.Now;
            var idade = (today.Year - DataNascimento.Year);
            if (DataNascimento > today.AddYears(-idade)) 
                idade--;
            return idade;
        }

        private void Validar()
        {
            ValidarNome();
            ValidarDataNascimento();
            ValidarValorDependente();
            ValidationResult = Validate(this);
        }

        private void ValidarNome()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório")
                .Length(2, 60).WithMessage("O nome precisa ter entre 2 e 60 caracteres");
        }

        private void ValidarDataNascimento()
        {
            RuleFor(p => p.DataNascimento)
                .LessThan(DateTime.Now)
                .WithMessage("A data de nascimento deve ser menor que a data atual");
        }

        private void ValidarValorDependente()
        {
            RuleFor(p => p.Valor)
                .GreaterThan(0).When(x => x.Tipo == ETipoType.Dependente)
                .WithMessage("O valor para pessoa dependente deve ser 0");
        }

    }
}
