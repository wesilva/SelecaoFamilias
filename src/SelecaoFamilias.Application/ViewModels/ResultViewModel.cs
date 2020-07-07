using System.Collections.Generic;

namespace SelecaoFamilias.Application.ViewModels
{
    public class ResultViewModel
    {
        public List<string> Mensagens { get; private set; }
        public bool Sucesso => Mensagens.Count == 0;        
        public void AdicionarMensagens(IList<string> mensagens) => Mensagens.AddRange(mensagens);
        public void AdicionarMensagem(string mensagem) => Mensagens.Add(mensagem);
    }
}
