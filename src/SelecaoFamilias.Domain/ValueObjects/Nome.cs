using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string nome)
        {
            Texto = nome;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Texto, "Nome.Texto", "Nome é obrigatório")
            );
        }

        public string Texto { get; private set; }
    }
}
