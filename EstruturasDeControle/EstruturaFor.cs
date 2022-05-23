namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaFor
{
    public static void Exercicios()
    {
        double somatorio = 0;
        string entrada;
        
        Console.WriteLine("Informe o tamanho da turma: ");
        entrada = Console.ReadLine();
        int.TryParse(entrada, out int tamanhoTurma);

        for (int i = 1; i <= tamanhoTurma; i++)
        {
            Console.WriteLine("Informe a nota da pessoa discente {0}: ", i);
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double notaAtual);

            somatorio += notaAtual;
        }

        double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
        Console.WriteLine("Media da turma {0}", media);
    }
}