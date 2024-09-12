using System.Globalization;

namespace Aula03.MembrosEstaticos;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circulo = Calculadora.Circunferencia(raio);
        double volume = Calculadora.Volume(raio);
        
        Console.WriteLine("Circunferência: " + circulo.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
    
}
