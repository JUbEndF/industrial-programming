using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace промышленное_програмирование_LUB1.model
{
    class Circle : Figure
    {
        private double Radius { get; init; }
        private Point Center { get; init; }

        public Circle(Point a, double r)
        {
            Center = a;
            Radius = r;
        }

        public override double perimeter() => 2*Math.PI*Radius;

        public override Rectangle framing_rectangle() => new(new Point(Center.X - Radius, Center.Y - Radius),
                                                            new Point(Center.X + Radius, Center.Y + Radius));

        public override double square() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString() => $"Circle: Center{Center}, radius = {Radius}";

        public override bool Equals(object? obj)
        {
            if (obj is not Circle other)
                return false;
            return Radius == other.Radius &&
                   Center == other.Center;
            //return Equals(obj as Circle);
        }

        //public bool Equals(Circle other)
        //{
        //    return other != null &&
        //           Radius == other.Radius &&
        //           Center == other.Center;
        //}

        public override int GetHashCode()
        {
            return HashCode.Combine(Center, Radius) ;
        }
    }
}
