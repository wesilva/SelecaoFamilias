using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class Idade : ValueObject
    {
        public Idade(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Idade.data", "Data de nascimento inválida")
            );
        }

        public DateTime DataNascimento { get; private set; }

        public int ObterIdade()
        {
            var today = DateTime.Now;
            var idade = (today.Year - DataNascimento.Year);
            if (DataNascimento > today.AddYears(-idade))
                idade--;
            return idade;
        }

        private bool Validate()
        {
            if (DataNascimento == DateTime.MinValue)          
                return false;

            if (DataNascimento > DateTime.Today)
                return false;
            return true;            
        }
    }
}
