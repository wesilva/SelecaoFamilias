using FluentValidation;
using FluentValidation.Results;
using System;


namespace SelecaoFamilias.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }
        public Guid Id { get; private set; }
        public abstract bool EhValido();
        public ValidationResult ValidationResult { get; protected set; }
    }
}
