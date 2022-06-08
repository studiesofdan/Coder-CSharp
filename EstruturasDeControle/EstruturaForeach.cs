namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaForeach
{
    public static void Exercicios()
    {
        var palavra = "Opa!";

        foreach (var letra in palavra)
        {
            Console.WriteLine(letra);
        }

        var alunos = new string[] {"Ana", "Bia", "Sarah"};

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
        {
            
        }
    }
}