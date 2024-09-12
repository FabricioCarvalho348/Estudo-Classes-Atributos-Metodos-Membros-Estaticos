﻿using System.Globalization;

namespace Aula01.ResolucaoDeProblemaComPoo;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;
        
        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("Entre com as medidas do triângulo X: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.CalcularArea();
        double areaY = y.CalcularArea();

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área: X");
        }
        else if (areaX < areaY)
        {
            Console.WriteLine("Maior área: Y");
        }
        else
        {
            Console.WriteLine("As áreas são iguais.");
        }
        
        // RESOLUÇÃO SEM UTILIZAR POO
        // double xA, xB, xC, yA, yB, yC;
        //
        // Console.WriteLine("Entre com as medidas do triângulo X: ");
        // xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //
        // Console.WriteLine("Entre com as medidas do triângulo X: ");
        // yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //
        // double p = (xA + xB + xC) / 2.0;
        // double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
        //
        // p = (yA + yB + yC) / 2.0;
        // double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
        //
        // Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        // Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        //
        // if (areaX > areaY)
        // {
        //     Console.WriteLine("Maior área: X");
        // }
        // else if (areaX < areaY)
        // {
        //     Console.WriteLine("Maior área: Y");
        // }
        // else
        // {
        //     Console.WriteLine("As áreas são iguais.");
        // }
    }
}