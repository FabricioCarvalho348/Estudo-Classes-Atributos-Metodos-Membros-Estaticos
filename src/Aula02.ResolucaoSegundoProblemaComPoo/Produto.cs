using System.Globalization;

namespace Aula02.ResolucaoSegundoProblemaComPoo;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarQuantidadeAoEstoque(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverQuantidadeDoEstoque(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return Nome 
               + ", $ " 
               + Preco.ToString("F2", CultureInfo.InvariantCulture) 
               + ", " 
               + Quantidade 
               + " unidades, Total: $ " 
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}