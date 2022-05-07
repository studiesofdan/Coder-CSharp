namespace Coder_CSharp.Fundamentos;

public class OperadoresTernarios
{
    public static void Exercicios()
    {
        var nota = 9.0;
        bool bomComportamento = true;
        string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
        Console.WriteLine(resultado);
    }
}