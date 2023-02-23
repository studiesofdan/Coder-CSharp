namespace Coder_CSharp.ClassesEMetodos._05___AtributosEstaticos;

public class Produto
{
    public string Nome;
    public double Preco;
    public static double Desconto;

    public Produto(string nome, double preco, double desconto)
    {
        Nome = nome;
        Preco = preco;
        Desconto = desconto;
    }
    
    public Produto() { }

    public double CalcularDesconto()
    {
        return Preco - Preco * Desconto;
    }
}