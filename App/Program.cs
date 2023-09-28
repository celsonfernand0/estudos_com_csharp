using System.Data;
using App;

namespace Aula;

public static class Program
{
    public static void Main(string[] args)
    {
        List<Produtos> listProdutos = new List<Produtos>();
        string? produto;
        decimal preco;
        bool cond = true;
        while (cond)
        {
            System.Console.WriteLine("Digite o nome do Produto");
            produto = Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine("Digite o preço do produto");
            preco = Decimal.Parse(Console.ReadLine());
            Console.Clear();

            listProdutos.Add(
                new Produtos()
                {
                    NomeProdutos = produto,
                    ValorPrecos = preco
                }
            );

            System.Console.WriteLine("Se vc deseja continuar a preencher a lista digite 1 se deseja parar e exibir a lista digite qualque tecla");
            char op = Char.Parse(Console.ReadLine());
            if (op != '1')
            {
                cond = false;
            }
            Console.Clear();
        }

        Console.Clear();
        listProdutos.Sort();
        System.Console.WriteLine("A lista de produtos de a seguite:");
        foreach (var item in listProdutos)
        {
            System.Console.WriteLine($"{item.NomeProdutos} - {item.ValorPrecos} kz");
        }
    }

}
