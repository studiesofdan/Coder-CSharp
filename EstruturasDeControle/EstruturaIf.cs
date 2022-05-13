namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaIf
{
    public static void Exercicios()
    {
        bool bomComportamento = false;
        string entrada;
        
        Console.WriteLine("Digite a nota do discente: ");
        entrada = Console.ReadLine();
        Double.TryParse(entrada, out double nota);
        
        Console.WriteLine("Possui bom comportamento? ");
        entrada = Console.ReadLine();

        bomComportamento = entrada.ToLower() == "s";

        if (nota >= 9.0 && bomComportamento)
        { 
            Console.WriteLine("Discente ganhou 3 dias de viagem para a Finlandia");
        }
    }
}