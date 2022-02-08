using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace промышленное_програмирование_LUB1.model
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y) { X = x; Y = y; }

        public double distance(Point second)
        {
            return Math.Sqrt(Math.Pow((X - second.X), 2) + Math.Pow((Y - second.Y), 2));
        }
        public override string ToString() => $"({X}, {Y})";
    }
}
