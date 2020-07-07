using SelecaoFamilias.Sorteio.ValueObjects;

namespace SelecaoFamilias.Sorteio.Criterios.Dependentes
{
    public class CriterioFamiliasCom1Ou2Dependentes : CriterioDependentes
    {
        public override Pontuacao Pontuacao => Pontuacao.Dois();

        public CriterioFamiliasCom1Ou2Dependentes(int quantidadeDependentes)
            : base(quantidadeDependentes, qtdDeDependentes => qtdDeDependentes > 0 && qtdDeDependentes < 3) 
        { }
    }
}
