using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for ( int i=1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle ( r or c ) ?");
                char opc = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (opc == 'r')
                {
                    Console.Write("Width :");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height :");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));
                }
                if (opc == 'c')
                {
                    Console.Write("Radius :");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Color.ToString() + " " + shape.Area().ToString("F2"));
            }
        }
    }
}
