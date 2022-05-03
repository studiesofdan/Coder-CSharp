namespace Coder_CSharp.Fundamentos;

public class OperadoresAritmeticos
{
    public static void Exercicios()
    {
        // Preço desconto
        var preco = 1000.0;
        var imposto = 355;
        var desconto = 0.3;

        double total = preco + imposto;
        var totalComDesconto = total - (total * desconto);
        Console.WriteLine("O preço final � {0}", totalComDesconto);
        
        
        // IMC
        double peso = 91.2;
        double altura = 1.82;
        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine($"IMC e {imc}.");
        
        // Numero par / impar
        int par = 24;
        int impar = 55;
        Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
        Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
    }
}