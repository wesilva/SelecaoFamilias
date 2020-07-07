using SelecaoFamilias.Domain.Core.Entities;
using System.Collections.Generic;

namespace SelecaoFamilias.Domain.Entities
{
    public class Status : Entity
    {
        public int Id { get; }
        public string Descricao { get; }
        public bool StatusValido { get; }

        public Status(int id, string descricao, bool statusValido)
        {
            Id = id;
            Descricao = descricao;
            StatusValido = statusValido;
        }

        public virtual ICollection<Familia> Familias { get; set;}

        public override bool EhValido()
        {
           return true;
        }
    }
}
