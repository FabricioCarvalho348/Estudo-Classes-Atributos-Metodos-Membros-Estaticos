using System.Globalization;

namespace Aula02.ResolucaoSegundoProblemaComPoo;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        
        Console.WriteLine("Entre os dados do Produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);
        
        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
        int addQuantidade = int.Parse(Console.ReadLine());
        p.AdicionarQuantidadeAoEstoque(addQuantidade);
        Console.WriteLine("Dados atualizados " + p);
        
        Console.WriteLine();
        
        Console.Write("Digite o número de produtos a serem removidos do estoque: ");
        int removerQuantidade = int.Parse(Console.ReadLine());
        p.RemoverQuantidadeDoEstoque(removerQuantidade);
        Console.WriteLine("Dados atualizados " + p);
    }
}