using System;
using System.Globalization;

namespace Secao4_Produto1
{
    class Program
    {
        static void Main(string[] args)
        {                     
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto prod = new Produto(nome, preco, quantidade);

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + prod);

            Console.WriteLine("");
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(quant);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + prod);

            Console.WriteLine("");
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            quant = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(quant);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + prod);
        }
    }
}
