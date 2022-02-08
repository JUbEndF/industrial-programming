using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace промышленное_програмирование_LUB1.model
{
    class Rectangle : Figure
    {
        private Point First { get; set; }

        private Point Second { get; set; }

        public Rectangle(Point point1, Point point2)
        {
            First = point1;
            Second = point2;
        }

        private double A => Math.Abs(First.X - Second.X);
        private double B => Math.Abs(First.Y - Second.Y);

        public override Rectangle framing_rectangle() => new Rectangle(First, Second);

        public override double perimeter => 2 * (A + B);

        public override double square() => A * B;

        public override string ToString() => $"{First}&{Second}: a = {A}, b = {B}";
    }
}
