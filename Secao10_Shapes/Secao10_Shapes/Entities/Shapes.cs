using Secao10_Shapes.Entities.Enums;

namespace Secao10_Shapes.Entities
{
    abstract class Shapes
    {
        public Color  Color { get; set; }

        public Shapes()
        {
        }

        public Shapes(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
