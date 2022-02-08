using System;
using System.Linq;
using System.Collections;

namespace промышленное_програмирование_LUB1.model
{
    class Triangle : Figure
    {

        public Point[] Arr_vertexes { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            Arr_vertexes = new Point[3] { a, b, c };
        }

        public override Rectangle framing_rectangle() => new(new Point(Arr_vertexes.Min(arr_vertexes => arr_vertexes.X),
                Arr_vertexes.Min(arr_vertexes => arr_vertexes.Y)), 
            new Point(Arr_vertexes.Max(arr_vertexes => arr_vertexes.X), 
                Arr_vertexes.Max(arr_vertexes => arr_vertexes.Y)));

        public override double perimeter => Arr_vertexes[0].distance(Arr_vertexes[1]) + Arr_vertexes[0].distance(Arr_vertexes[2]) + Arr_vertexes[1].distance(Arr_vertexes[2]);

        public override double square()
        {
            var per = perimeter/2;
            return Math.Sqrt(per * (per - Arr_vertexes[0].distance(Arr_vertexes[1])) *(per - Arr_vertexes[0].distance(Arr_vertexes[2])) *(per - Arr_vertexes[1].distance(Arr_vertexes[2])));
        }

        public override string ToString() => $"A{Arr_vertexes[0]}, B{Arr_vertexes[1]}, C{Arr_vertexes[2]}";
    }
}
