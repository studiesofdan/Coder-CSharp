using System.Globalization;

namespace Coder_CSharp.Fundamentos;

public class FormatarNumeros
{
    public static void Exercicios()
    {
        double valor = 19.894;
        
        // Arredondamento
        Console.WriteLine(valor.ToString("F1"));
        
        // Moeda
        Console.WriteLine(valor.ToString("C"));
        
        // Percentual
        Console.WriteLine(valor.ToString("P"));
        
        // Notacao de dois numeros 
        Console.WriteLine(valor.ToString("#.##"));
        
        // Recebe valor que configura moeda para pt-BR e passa valor sem nenhuma casa decimal
        CultureInfo cultura = new CultureInfo("pt-BR");
        Console.WriteLine(valor.ToString("C0", cultura));
        
        // Preencher com zeros a esquerda
        int inteiro = 256;
        Console.WriteLine(inteiro.ToString("D10"));
    }
}