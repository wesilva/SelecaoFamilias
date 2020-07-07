using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Sorteio.ValueObjects;
using System;

namespace SelecaoFamilias.Sorteio.Criterios.Dependentes
{
    public abstract class CriterioDependentes : ICriterio
    {
        public abstract Pontuacao Pontuacao { get; }
        protected int QuantidadeDeDependentes { get; }
        protected Func<int, bool> Condicao { get; }

        protected CriterioDependentes(int quantidadeDependentes, Func<int, bool> condicao)
        {
            QuantidadeDeDependentes = quantidadeDependentes;
            Condicao = condicao;
        }

        public bool EhAtendido()
        {
            return Condicao.Invoke(QuantidadeDeDependentes);
        }
    }
}
