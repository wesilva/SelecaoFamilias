using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.Interfaces;

namespace SelecaoFamilias.Infra.Data.Factories
{
    public sealed class FamiliaFactory : IFamiliaFactory
    {
        public Familia Criar(Status status)
        {
            return new Familia(status);
        }

        public void AdicionarPessoa(Familia familia, NomeCompleto nome, Idade idade, ETipoType tipo, Renda renda)
        {
            familia.AdicionarPessoa(nome, tipo, idade, renda);
        }
    }
}
