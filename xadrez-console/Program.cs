using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8, 8);

            t.ColocarPeca(new Torre(t, Cor.Preta), new Posicao(0, 0));
            t.ColocarPeca(new Torre(t, Cor.Preta), new Posicao(1, 3));
            t.ColocarPeca(new Rei(t, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(t);
        }
    }
}