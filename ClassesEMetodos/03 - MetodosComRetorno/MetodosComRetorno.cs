namespace Coder_CSharp.ClassesEMetodos._03___MetodosComRetorno;

public class MetodosComRetorno
{
    public static void Exercicios()
    {
        CalculadoraComum calc = new CalculadoraComum();
        var resultadoSoma = calc.Somar(2, 2);
        Console.WriteLine(resultadoSoma);
    }
}