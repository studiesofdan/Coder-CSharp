namespace Coder_CSharp.Fundamentos;

public class OperadoresRelacionais
{
    public static void Exercicios()
    {
        Console.Write("Digite a nota: ");
        double.TryParse(Console.ReadLine(), out double nota);
        double notaDeCorte = 7.0;

        Console.WriteLine("Nota inv�lida? {0}", nota > 10.0);
        Console.WriteLine("Nota inv�lida? {0}", nota < 0.0);
        Console.WriteLine("Perfeito? {0}", nota == 10.0);
        Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
        Console.WriteLine("Passou por m�dia? {0}", nota >= notaDeCorte);
        Console.WriteLine("Recuperaç�o? {0}", nota < notaDeCorte);
        Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        
    }
}