namespace Aula03.MembrosEstaticos;

public class Calculadora
{
    public static double Pi = 3.14;

    
    public static double Circunferencia(double raio)
    {
        return 2.0 * Pi * raio;
    }

    public static double Volume(double raio) => 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
}