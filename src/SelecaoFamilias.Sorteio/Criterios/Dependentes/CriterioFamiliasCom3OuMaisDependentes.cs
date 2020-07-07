using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.Dependentes
{
    public class CriterioFamiliasCom3OuMaisDependentes : CriterioDependentes
    {
        public override Pontuacao Pontuacao => Pontuacao.Tres();

        public CriterioFamiliasCom3OuMaisDependentes(int quantidadeDependentes)
            : base(quantidadeDependentes, qtdDeDependentes => qtdDeDependentes > 2)
        { }
    }
}
