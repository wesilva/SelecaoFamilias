using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class NomeCompleto : ValueObject
    {
        public NomeCompleto(string nome)
        {
            Nome = nome;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Nome, "Nome.Texto", "Nome é obrigatório")
            );
        }

        public string Nome { get; private set; }
    }
}
