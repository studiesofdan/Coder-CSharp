namespace Coder_CSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Exercicios()
        {
            // Area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area eh" + area);
            
            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);
            
            // byte vai de 0 a 256
            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            
            // sbyte vai de -127 a +128
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);
            
            // Inteiro assinado de 32 bits
            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);
            
            // inteiro sem sinal
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 8_000_000_000;
            Console.WriteLine("Populacao Mundial" + populacaoMundial);
            
            float precoComputador = 1299.99f;
            Console.WriteLine("Preco do computador " + precoComputador);

            double valorDeMercadoDeNada = 0.00;
            Console.WriteLine("Nada " + valorDeMercadoDeNada);
            
            decimal distanciaEntreEstrelas = Decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }   
}