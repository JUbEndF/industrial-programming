using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace промышленное_програмирование_LUB1.model
{
    class Rectangle : Figure
    {
        public Point First { get; set; }

        public Point Second { get; set; }

        public Rectangle(Point point1, Point point2)
        {
            First = point1;
            Second = point2;
        }

        private double A => Math.Abs(First.X - Second.X);
        private double B => Math.Abs(First.Y - Second.Y);

        public override Rectangle framing_rectangle()
        {
            return 0;
        }

        public override double perimeter()
        {
            return 2 * (A + B);
        }

        public override double square()
        {
            return A * B;
        }
    }
}
