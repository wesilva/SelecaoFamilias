using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class Descricao : ValueObject
    {
        public Descricao(string value)
        {
            Value = value;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Value, "Descricao.Texto", "Descricao é obrigatório")
            );
        }

        public string Value { get; private set; }
    }
}
