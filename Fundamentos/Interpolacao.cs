namespace Coder_CSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Exercicios()
        {
            string produto = "Notebook Positivo";
            string modelo = "XS7010";
            double preco = 1000.00;
            
            // opcao 1
            Console.WriteLine("O produto " + produto + " modelo " + modelo + " custa R$" + preco + ".");
            
            // opcao 2
            Console.WriteLine("O produto {0} modelo {1} custa {2}", 
                produto, modelo, preco);

            // opcao 3
            Console.WriteLine($"O produto {produto} eh legal! ");
        }
    }   
}