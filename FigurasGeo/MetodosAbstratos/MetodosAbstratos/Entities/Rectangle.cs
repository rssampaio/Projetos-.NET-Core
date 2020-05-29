using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return "Retangulo cor = "
                + Color
                + ", Altura = "
                + Height.ToString("F2")
                + ", Largura = "
                + Width.ToString("F2")
                + ", Área = "
                + Area().ToString("F2");

        }
    }
}
