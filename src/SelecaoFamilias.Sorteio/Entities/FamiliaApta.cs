using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.Entities;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;
using System;
using System.Collections.Generic;

namespace SelecaoFamilias.Sorteio.Entities
{
    public class FamiliaApta : Entity
    {
        public FamiliaApta(EntityId familiaId,
            IEnumerable<ICriterio> criteriosAtendidos)
        {
            Id = new EntityId(Guid.NewGuid());
            FamiliaId = familiaId;
            DataSelecao = DateTime.Now;
            CriteriosAtendidos = new CriteriosAtendidos(criteriosAtendidos);
            PontuacaoTotal = CriteriosAtendidos.PontuacaoTotal;
        }

        public EntityId Id { get; private set; }

        public EntityId FamiliaId { get; private set; }

        public Pontuacao PontuacaoTotal { get; private set; }

        public DateTime DataSelecao { get; private set; }

        public Familia Familia { get; private set; }

        public CriteriosAtendidos CriteriosAtendidos { get; set; }

        public override bool EhValido()
        {
            return true;
        }
    }
}
