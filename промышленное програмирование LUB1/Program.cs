using System;
using промышленное_програмирование_LUB1.model;
namespace промышленное_програмирование_LUB1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Menu<Figure>();
            figure.Add(new Triangle(
                new Point(1,2),
                new Point(0, 6),
                new Point(3,2)
                ));
            figure.Add(new Triangle(
                new Point(1, 9),
                new Point(5, 6),
                new Point(4, 7)
                ));
            figure.Add(new Rectangle(
                new Point(1, 2),
                new Point(0, 6)
                ));

            figure.Print();

            figure.Comparison(0, 2);
        }
    }
}
