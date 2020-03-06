using System;
using System.Globalization;

namespace OrientacaoObject
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre  com as medidas do triangulo X");
            x.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Entre  com as medidas do triangulo Y");
            y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcArea();

            double areaY = y.CalcArea();

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
