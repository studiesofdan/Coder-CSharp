using Console = System.Console;

namespace Coder_CSharp.ClassesEMetodos._04___MetodosEstaticos;

public class MetodosEstaticos
{
    public static void Exercicios()
    {
        /*
         * Quando utilizado a palavra static, nao eh necessario
         * utilizar a instancia, pois ele pertence a classe e nao ao objeto
         */
        var somar = CalculadoraEstatica.Somar(2, 3);
        Console.WriteLine(somar);
        
        var subtrair = CalculadoraEstatica.Subtrair(6, 3);
        Console.WriteLine(subtrair);
        
        var multiplicar = CalculadoraEstatica.Multiplicar(9, 6);
        Console.WriteLine(multiplicar);
        
        var dividir = CalculadoraEstatica.Dividir(12, 4);
        Console.WriteLine(dividir);
    }
}