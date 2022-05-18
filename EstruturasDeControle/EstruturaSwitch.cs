namespace Coder_CSharp.EstruturasDeControle;

public class EstruturaSwitch
{
    public static void Exercicios()
    {
        Console.WriteLine("Escolha um dos 3 ultimos albuns da Taylor Swift e veja um trecho de musica: ");
        Console.WriteLine("1)Lover  2)Folklore  3) Evermore");
        int.TryParse(Console.ReadLine(), out int album);

        switch (album)
        {
            case 1:
                Console.WriteLine("Killing me slow, out the window / I'm always waiting for you to be waiting below");
                break;
            case 2:
                Console.WriteLine("I didn't have it in myself to go with grace / And so the battleships will sink beneath the waves");
                break;
            case 3:
                Console.WriteLine("Gleaming, twinkling / Eyes like sinking ships on waters / So inviting, I almost jump in");
                break;
            default:
                Console.Write("Invalid option");
                break;
        }
    }
}