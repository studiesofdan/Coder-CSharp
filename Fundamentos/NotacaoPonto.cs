namespace Coder_CSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Exercicios()
        {
            var saudacao = "ola".ToUpper().Insert(3, "World!")
                .Replace("World", "Mundo");
            Console.WriteLine(saudacao);
        }
    }   
}