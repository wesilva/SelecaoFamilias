
using Flunt.Notifications;

namespace SelecaoFamilias.Domain.Core.Entities
{
    public abstract class Entity : Notifiable
    {
        public abstract bool EhValido();
    }
}
