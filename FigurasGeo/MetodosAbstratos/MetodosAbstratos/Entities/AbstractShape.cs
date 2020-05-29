using MetodosAbstratos.Entities.Enums;
using MetodosAbstratos.Services;

namespace MetodosAbstratos.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
