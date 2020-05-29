using MetodosAbstratos.Entities.Enums;
using System;

namespace MetodosAbstratos.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return "Circulo cor = " 
                + Color
                + ", Raio = "
                + Radius.ToString("F2")
                + ", Área = "
                + Area().ToString("F2");

        }
    }
}
