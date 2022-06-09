namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaContinue
{
    public static void Exercicios()
    {
        int intervalo = 50;
        Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

        for (int i = 1; i <= intervalo; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }
            Console.Write(i + " ");
        }
    }
}