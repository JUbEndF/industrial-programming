using System;
using System.Linq;
using System.Collections;

namespace промышленное_програмирование_LUB1.model
{
    class Triangle : Figure
    {

        public Point[] Arr_vertexes { get; init; }

        public Triangle(Point a, Point b, Point c)
        {
            Arr_vertexes = new Point[3] { a, b, c };
        }

        private double A => Arr_vertexes[0].distance(Arr_vertexes[1]);
        private double B => Arr_vertexes[0].distance(Arr_vertexes[2]);
        private double C => Arr_vertexes[2].distance(Arr_vertexes[1]);

        public override Rectangle framing_rectangle() => new(new Point(Arr_vertexes.Min(arr_vertexes => arr_vertexes.X),
                Arr_vertexes.Min(arr_vertexes => arr_vertexes.Y)), 
            new Point(Arr_vertexes.Max(arr_vertexes => arr_vertexes.X), 
                Arr_vertexes.Max(arr_vertexes => arr_vertexes.Y)));

        public override double perimeter() => A + B + C;

        public override double square()
        {
            var per = perimeter()/2;
            return Math.Sqrt(per * (per - A) *(per - B) *(per - C));
        }

        public override string ToString() => $"Triangle: A:{A}, B:{B}, C:{C}";

        public override bool Equals(object? obj)
        {
            if (obj is not Triangle other)
                return false;
            return A == other.A &&
                B == other.B &&
                C == other.C;
        }



        public override int GetHashCode()
        {
            return HashCode.Combine<Point, Point, Point>(Arr_vertexes[0], Arr_vertexes[1], Arr_vertexes[2]);
        }
    }
}
