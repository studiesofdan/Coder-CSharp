namespace Coder_CSharp.ClassesEMetodos.Construtores
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {
            
        }
    }

    class Construtores
    {
        public static void Exercicios()
        {
            var carroUm = new Carro();
            carroUm.Fabricante = "Kia";
            carroUm.Modelo = "Picanto";
            carroUm.Ano = 2022;
            
            Console.WriteLine($"{carroUm.Fabricante} {carroUm.Modelo} {carroUm.Ano}");
        }
    }
}