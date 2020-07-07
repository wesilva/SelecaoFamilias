using System;

namespace SelecaoFamilias.Domain.Core.Entities
{
    public abstract class IdBase : IEquatable<IdBase>
    {
        public Guid Valor { get; }

        public IdBase(Guid valor)
        {
            Valor = valor;
        }

        public Guid ToGuid()
        {
            return this.Valor;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is IdBase outro && Equals(outro);
        }

        public bool Equals(IdBase outroId)
        {
            return this.Valor == outroId.Valor;
        }

        public static bool operator ==(IdBase obj1, IdBase obj2)
        {
            if (object.Equals(obj1, null))
            {
                if (object.Equals(obj2, null))
                {
                    return true;
                }

                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(IdBase obj1, IdBase obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
