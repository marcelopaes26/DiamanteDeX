namespace DiamanteDeX;

internal class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();

        int tamanhoDoDiamante = ObterTamanhoDoDiamante();

        GeradorDeDiamante.DesenharDiamante(tamanhoDoDiamante);

        Console.ReadLine();
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("\tDiamante de X");
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine();
    }

    static int ObterTamanhoDoDiamante()
    {
        Console.Write("Digite um número ímpar e positivo: ");
        int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

        if (tamanhoDiamante <= 0 || tamanhoDiamante % 2 == 0)
        {
            Console.WriteLine("O número deve ser ímpar e positivo!");
            return 0;
        }

        return tamanhoDiamante;
    }
}