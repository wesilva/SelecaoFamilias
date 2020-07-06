using System;
using System.Collections.Generic;
using System.Text;

namespace SelecaoFamilias.Domain.Enums
{
    public enum EStatusType
    {
        CadastroValido = 0,
        JaPossuiUmaCasa = 1,
        SelecionadaEmOutroProcessoDeSelecao = 2,
        CadastroIncompleto = 3
    }
}
