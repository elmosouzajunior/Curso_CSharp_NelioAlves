using Secao10_Shapes.Entities.Enums;
using System;

namespace Secao10_Shapes.Entities
{
    class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
