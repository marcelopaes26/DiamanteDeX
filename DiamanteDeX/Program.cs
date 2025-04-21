namespace DiamanteDeX;

internal class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();

        GeradorDeDiamante geradorDeDiamante = new GeradorDeDiamante();

        int tamanhoDoDiamante = geradorDeDiamante.ObterTamanhoDoDiamante();

        geradorDeDiamante.DesenharDiamante(tamanhoDoDiamante);
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("\tDiamante de X");
        Console.WriteLine("-----------------------------");

        Console.WriteLine();
    }
}