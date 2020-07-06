using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class Renda : ValueObject
    {
        public Renda(decimal valor)
        {
            Valor = valor;

            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, Valor, "Renda.valor", "A renda não pode ser menor que Zero")
            );
        }

        public decimal Valor { get; private set; }
    }
}
