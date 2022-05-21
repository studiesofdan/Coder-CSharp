namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaDoWhile
{
    public static void Exercicios()
    {
        string entrada;

        do
        {
            Console.WriteLine("Qual o seu nome? ");
            entrada = Console.ReadLine();

            Console.WriteLine("Seja bem-vindo {0}", entrada);
            Console.WriteLine("Deseja continuar? (S/N)");
            entrada = Console.ReadLine();
        } while (entrada.ToLower() == "s");
    }
}