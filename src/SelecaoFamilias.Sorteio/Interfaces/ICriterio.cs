using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Domain.Core.Interfaces
{
    public interface ICriterio
    {
        Pontuacao Pontuacao { get; }
        bool EhAtendido();
    }
}
