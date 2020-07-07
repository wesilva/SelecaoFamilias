using SelecaoFamilias.Domain.Core.Interfaces;
using SelecaoFamilias.Domain.ValueObjects;
using SelecaoFamilias.Sorteio.ValueObjects;
using System;

namespace SelecaoFamilias.Sorteio.Criterios.IdadePretendente
{
    public abstract class CriterioIdadePretendente : ICriterio
    {
        public abstract Pontuacao Pontuacao { get; }
        protected Idade Idade { get; }
        protected Func<Idade, bool> Condicao { get; }

        protected CriterioIdadePretendente(Idade idade, Func<Idade, bool> condicao)
        {
            Idade = idade;
            Condicao = condicao;
        }

        public bool EhAtendido()
        {
            return Condicao.Invoke(Idade);
        }
    }
}
