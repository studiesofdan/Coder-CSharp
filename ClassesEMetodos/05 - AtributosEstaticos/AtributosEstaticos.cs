namespace Coder_CSharp.ClassesEMetodos._05___AtributosEstaticos;

public class AtributosEstaticos
{
    public static void Exercicios()
    {
        var novoProduto = new Produto("Urso de Pelucia", 399.00, 0.20);
        
        var novoProduto2 = new Produto()
        {
            Nome = "Energetico Monster Mango Loco",
            Preco = 7.99
        };
        
        /* Atribuir sempre aos produtos um desconto de 1% */
        Produto.Desconto = 0.01;
        
        Console.WriteLine(novoProduto.CalcularDesconto());
        Console.WriteLine(novoProduto2.CalcularDesconto());
    }
}