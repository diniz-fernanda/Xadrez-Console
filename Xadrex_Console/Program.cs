using tabuleiro;
using Xadrex_Console;
using xadrez;

try
{

    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
    tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

    Tela.imprimirTabuleiro(tab);
}
catch(TabuleiroException erro)
{
    Console.WriteLine(erro.Message);
}
Console.ReadLine();