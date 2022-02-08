using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace промышленное_програмирование_LUB1.model
{
    class Circle : Figure
    {
        private double Radius { get; set; }
        private Point Center { get; set; }

        public Circle(Point a, double r)
        {
            Center = a;
            Radius = r;
        }

        public override double perimeter => 2*Math.PI*Radius;

        public override Rectangle framing_rectangle() => new Rectangle(new Point(Center.X - Radius, Center.Y - Radius), new Point(Center.X + Radius, Center.Y + Radius));

        public override double square() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString() => $"Center{Center}, radius = {Radius}";
    }
}
