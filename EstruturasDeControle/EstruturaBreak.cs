namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaBreak
{
    public static void Exercicios()
    {
        Random random = new Random();
        int numero = random.Next(1, 51);
        
        Console.WriteLine("O numero que queremos e: {0}.", numero);

        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine("{0} e o numero que queremos? ", i);
            if (i == numero)
            {
                Console.WriteLine("Sim!");
            }
            else
            {
                Console.WriteLine("Nao!");
            }
        }
        
        Console.WriteLine("Fim!");
    }
}