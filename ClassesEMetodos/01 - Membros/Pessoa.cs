namespace Coder_CSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            if (Nome.Equals("") || Idade <= 0)
            {
                Console.WriteLine("Dados nao estao preenchidos");
            }
            
            return String.Format
                ($"Ola! Prazer, {Nome} e tenho {Idade} anos :)");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}