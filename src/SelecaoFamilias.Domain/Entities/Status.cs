using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.ValueObjects;
using System.Collections.Generic;

namespace SelecaoFamilias.Domain.Entities
{
    public class Status : Entity
    {
        public StatusId Id { get; }
        public Descricao Descricao { get; }
        public bool StatusValido { get; }

        public Status(StatusId id, Descricao descricao, bool statusValido)
        {
            Id = id;
            Descricao = descricao;
            StatusValido = statusValido;
        }
        protected Status() { }
        public virtual ICollection<Familia> Familias { get; set;}

        public override bool EhValido()
        {
            return true;
        }
    }
}
