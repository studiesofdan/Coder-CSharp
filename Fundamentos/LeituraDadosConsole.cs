using System.Globalization;

namespace Coder_CSharp.Fundamentos
{
    public class LeituraDadosConsole
    {
        public static void Exercicios()
        {
            Console.Write("Qual eh o seu nome? ");
            string nome = Console.ReadLine();
            
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            Console.Write("Qual o seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }   
}