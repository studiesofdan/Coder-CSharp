namespace Coder_CSharp.Fundamentos;

public class OperadoresLogicos
{
    public static void Exercicios()
    {
        var executouTrabalho1 = false;
        var executouTrabalho2 = false;

        bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
        Console.WriteLine("Comprou a TV 50? {0}", comprouTV50);
        
        bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
        Console.WriteLine("Comprou p sorvete? {0}", comprouSorvete);
        
        bool comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
        Console.WriteLine("Comprou a TV 50? {0}", comprouTV32);
        
        Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
    }
}