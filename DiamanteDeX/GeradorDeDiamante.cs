namespace DiamanteDeX;

public class GeradorDeDiamante
{
    static int espaco = 0;
    static int diferenca = 2;
    static List<string> listaDiamante;

    public int ObterTamanhoDoDiamante()
    {
        Console.Write("Digite um número ímpar e positivo: ");
        int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

        if (tamanhoDiamante <= 0 || tamanhoDiamante % 2 == 0)
        {
            Console.WriteLine("O número deve ser ímpar e positivo. \nTente novamente!");
            return ObterTamanhoDoDiamante();
        }

        listaDiamante = new List<string> {new string('x', tamanhoDiamante)};

        return tamanhoDiamante;
    }

    public void DesenharDiamante(int tamanhoDiamante)
    {
        while (true)
        {
            tamanhoDiamante -= diferenca;

            if (tamanhoDiamante <= 0)
            {
                break;
            }

            espaco += diferenca;
            string quantidade = $"{new string (' ', espaco / 2)}{new string ('x', tamanhoDiamante)}{new string (' ', espaco / 2)}";
            listaDiamante.Insert(0, quantidade);
            listaDiamante.Add(quantidade);            
        }
        foreach (string x in listaDiamante)
        {
            Console.WriteLine(x);
        }
    }

}