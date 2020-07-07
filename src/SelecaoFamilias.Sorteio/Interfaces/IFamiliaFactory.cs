using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;

namespace SelecaoFamilias.Sorteio.Interfaces
{
    public interface IFamiliaFactory
    {
        Familia Criar(Status status);

        void AdicionarPessoa(Familia familia, NomeCompleto nome, Idade idade, ETipoType tipo, Renda renda);
    }
}
