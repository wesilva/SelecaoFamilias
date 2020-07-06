using System;

namespace SelecaoFamilias.Domain.ValueObjects
{
    public class DataNascimento
    {
        public DataNascimento(DateTime data)
        {
            Data = data;
        }

        public DateTime Data { get; private set; }
    }
}
