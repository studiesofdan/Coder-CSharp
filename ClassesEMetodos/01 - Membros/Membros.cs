namespace Coder_CSharp.ClassesEMetodos;

public class Membros
{
    public static void Exercicios()
    {
        Pessoa dan = new Pessoa();
        dan.Nome = "Dan";
        dan.Idade = 27;
        
        dan.ApresentarNoConsole();

        Pessoa ts = new Pessoa();
        ts.Nome = "Taylor Swift";
        ts.Idade = 34;

        var apresentacaoPessoa = ts.Apresentar();
        Console.WriteLine(apresentacaoPessoa);
    }
}