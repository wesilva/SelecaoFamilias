using SelecaoFamilias.Domain.Core.ValueObjects;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class StatusId : ValueObject
    {
        public StatusId(int id)
        {
            Id = id;          
        }

        public int Id { get; private set; }
    }
}
