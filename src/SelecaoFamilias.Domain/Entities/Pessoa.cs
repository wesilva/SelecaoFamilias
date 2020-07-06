using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using System;

namespace SelecaoFamilias.Domain.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(EntityId familiaId, Nome nome, ETipoType tipo, Idade idade, Renda renda)
        {
            FamiliaId = familiaId;
            Id = new EntityId(Guid.NewGuid());
            Nome = nome;
            Tipo = tipo;
            Idade = idade;
            Renda = renda;

            AddNotifications(nome, idade, renda);
        }

        public EntityId FamiliaId { get; private set; }
        public EntityId Id { get; set; }
        public Nome Nome { get; private set; }
        public ETipoType Tipo { get; private set; }
        public Idade Idade { get; private set; }
        public Renda Renda { get; private set; }
        public Familia Familia { get; private set; }

        private Pessoa() { }

        public override bool EhValido()
        {
            return this.Valid;
        }
        public bool EhPretendente()
        {
            return Tipo == ETipoType.Pretendente;
        }

        public bool EhConjugue()
        {
            return Tipo == ETipoType.Conjugue;
        }

        public bool EhDependente()
        {
            return Tipo == ETipoType.Dependente;
        }

        public bool EhMenorDe18Anos()
        {
            return Idade.ObterIdade() < 18;
        }

        public int ObterIdade()
        {
            return Idade.ObterIdade();
        }
    }
}
