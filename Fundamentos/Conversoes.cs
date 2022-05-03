namespace Coder_CSharp.Fundamentos;

public class Conversoes
{
    public static void Exercicios()
    {
        // Conversao implicita
        int inteiro = 10;
        double quebrado = inteiro;
        Console.WriteLine(quebrado);
        
        // Conversao explicita
        double nota = 9.7;
        int notaTruncada = (int) nota;
        Console.WriteLine("Nota truncada {0}", notaTruncada);
        
        
        // Conversao string para int com int.Parse
        Console.WriteLine("Digite sua idade: ");
        string idadeString = Console.ReadLine();
        int idadeInteiro = int.Parse(idadeString);
        Console.WriteLine("Idade inserida: {0}", idadeInteiro);
        
        idadeInteiro = Convert.ToInt32(idadeString);
        Console.WriteLine("Resultado: {0}", idadeInteiro);
        
        
        // Conversao string para int com try.Parse
        Console.Write("Digite o primeiro numero: ");
        string palavra = Console.ReadLine();
        int numero1;
        int.TryParse(palavra, out numero1);
        Console.WriteLine("Resultado 1: {0}", numero1);
        
        Console.WriteLine("Digite o segundo numero: ");
        int.TryParse(Console.ReadLine(), out int numero2);
        Console.WriteLine("Resultado 2: {0}", numero2);
    }
}