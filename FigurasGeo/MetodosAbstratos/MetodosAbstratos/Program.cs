using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities.Enums;
using MetodosAbstratos.Services;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> listCircle = new List<Circle>();
            List<Rectangle> listRec = new List<Rectangle>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle ( r or c ) ?");
                char opc = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (opc == 'r' || opc == 'R')
                {
                    Console.Write("Width :");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height :");
                    double height = double.Parse(Console.ReadLine());

                    listRec.Add(new Rectangle(width, height, color));
                }
                if (opc == 'c' || opc == 'C')
                {
                    Console.Write("Radius :");
                    double radius = double.Parse(Console.ReadLine());

                    listCircle.Add(new Circle(radius, color));
                }   
            }

            Console.WriteLine();
            Console.WriteLine("Areas Retangulo");

            foreach (Rectangle rectangule in listRec)
            {
                Console.WriteLine(rectangule.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Areas Ciruclo");

            foreach (Circle circle in listCircle)
            {
                Console.WriteLine(circle.ToString());
            }

        }
    }
}
