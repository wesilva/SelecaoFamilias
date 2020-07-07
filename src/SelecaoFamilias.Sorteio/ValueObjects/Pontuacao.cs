using SelecaoFamilias.Domain.Core.ValueObjects;

namespace SelecaoFamilias.Sorteio.ValueObjects
{
    public class Pontuacao : ValueObject
    {
        public int Valor { get; }

        private Pontuacao(int valor)
        {
            Valor = valor;
        }

        public Pontuacao Somar(Pontuacao pontuacao) => new Pontuacao(this.Valor + pontuacao.Valor);

        public static Pontuacao Um() => new Pontuacao(1);

        public static Pontuacao Dois() => new Pontuacao(2);

        public static Pontuacao Tres() => new Pontuacao(3);

        public static Pontuacao Cinco() => new Pontuacao(5);

        public static Pontuacao operator +(Pontuacao p1, Pontuacao p2) => new Pontuacao(p1.Valor + p2.Valor);        

        //public static Pontuacao Criar(int valor) => new Pontuacao(valor);
    }
}
