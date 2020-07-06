using Flunt.Validations;
using SelecaoFamilias.Domain.Core.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class EntityId : ValueObject
    {
        public EntityId(Guid id)
        {
            Id = id;          
        }

        public Guid Id { get; private set; }
    }
}
