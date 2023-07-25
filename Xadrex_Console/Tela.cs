using tabuleiro;

namespace Xadrex_Console
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (var i = 0; i < tab.linhas; i++)
            {
                for (var j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
