using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;
using System;

namespace SelecaoFamilias.Sorteio.Criterios.RendaFamiliar
{
    public abstract class CriterioRendaFamiliar : ICriterio
    {
        public abstract Pontuacao Pontuacao { get; }
        protected Renda Renda { get; }
        protected Func<Renda, bool> Condicao { get; }

        protected CriterioRendaFamiliar(Renda renda, Func<Renda, bool> condicao)
        {
            Renda = renda;
            Condicao = condicao;
        }

        public bool EhAtendido()
        {
            return Condicao.Invoke(Renda);
        }
    }
}
