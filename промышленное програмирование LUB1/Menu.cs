using Spectre.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using промышленное_програмирование_LUB1.model;

namespace промышленное_програмирование_LUB1
{
    public class Menu : IMenu
    {
        private List<Figure> Figures = new List<Figure>();

        public Menu()
        {
            Deserialize();
        }

        public int get_index(int left, int right)
        {
            int index;
            do
                index = AnsiConsole.Prompt(new TextPrompt<int>($"[Green]Введите позицию от {left} до {right}: [/]"));
            while (index < left && index >= right);
            return index;
        }

        public int Count() => Figures.Count();

        public void Add(int index, Figure obj)
        {
            if(index >= Figures.Count)
            {
                Figures.Add(obj);
                return;
            }
            if (index >= 0)
                Figures.Insert(index, obj);

        }

        public Point create_point()
        {
            var X = AnsiConsole.Prompt(new TextPrompt<double>("[Green]Введите вещественную координату X:[/]"));
            var Y = AnsiConsole.Prompt(new TextPrompt<double>("[Green]Введите вещественную координату Y:[/]"));
            return new Point(X, Y);
        }

        private void Create_rectangle(int i)
        {
            AnsiConsole.WriteLine("Координата A");
            var A = create_point();
            AnsiConsole.WriteLine("Координата B");
            var B = create_point();
            var obj = new Rectangle(A, B);
            Add(i, obj);
        }

        private void create_triangle(int i)
        {
            AnsiConsole.WriteLine("Координата A");
            var A = create_point();
            AnsiConsole.WriteLine("Координата B");
            var B = create_point();
            AnsiConsole.WriteLine("Координата C");
            var C = create_point();
            var obj = new Triangle(A, B, C);
            this.Add(i, obj);
        }

        private void create_cirvle(int i)
        {
            AnsiConsole.WriteLine("Координата центра");
            var A = create_point();
            AnsiConsole.WriteLine("Радиус окружности");
            double B;
            do
                B = AnsiConsole.Prompt(new TextPrompt<double>("[Green]Введите вещественный радиус(0, +Б): [/]"));
            while (B <= 0) ;
            var obj = new Circle(A, B);
            this.Add(i, obj);
        }

        public void create_new_figure(int index)
        {
            var str = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("[green]Выберете тип создаваемой фигкры: [/]")
                .AddChoices("Прямоугольник", "Треугольник", "Круг"));
            switch (str)
            {
                case "Прямоугольник":
                    Create_rectangle(index);
                    break;
                case "Треугольник":
                    create_triangle(index);
                    break;
                case "Круг":
                    create_cirvle(index);
                    break;
            }
        }

        public void Remuve_element(int index)
        {
            Figures.RemoveAt(index);
        }

        public void Remuve()
        {
            Figures.Clear();
        }

        public void Comparison(int index_1, int index_2)
        {
            AnsiConsole.WriteLine($"{Figures[index_1]} == {Figures[index_2]}? {Figures[index_1].Equals(Figures[index_2])}");
        }

        private double Squere()
        {
            double rez = 0;
            foreach(var obj in Figures)
            {
                rez += obj.square();
            }
            return rez;
        }

        public void Print_Squere()
        {
            AnsiConsole.WriteLine($"Squere: {Squere()}");
            AnsiConsole.WriteLine($"Squere from linq: {Figures.Sum(x => x.square())}");
        }

        public double Squere(int index)
        {
            return Figures[index].square();
        }

        public double perimeter(int index)
        {
            return Figures[index].perimeter();
        }

        public void PrintElement(int index)
        {
            AnsiConsole.Write(Figures[index].ToString());
        }

        public void Print()
        {
            var table = new Table();
            table.AddColumn("Type");
            table.AddColumn("Element's");
            table.AddColumn("Squere");
            table.AddColumn("Leght");
            foreach(var obj in Figures)
            {
                table.AddRow(obj.GetType().Name, obj.ToString(), obj.square().ToString(), obj.perimeter().ToString());
                if(table.Rows.Count() == 10)
                {
                    table.AddRow("...", "...", "...", "...");
                    break;
                }
            }
            AnsiConsole.Write(table);
        }

        public void Serialize()
        {
            var xml = new XmlSerializer(typeof(List<Figure>));
            using (var filestream = new FileStream("C:\\Users\\Георгий\\source\\repos\\промышленное програмирование LUB1\\промышленное програмирование LUB1\\bin\\Debug\\net5.0\\figure.xml", FileMode.Create))
            {
                xml.Serialize(filestream, Figures);
            }
        }

        public void Deserialize()
        {
            var xml = new XmlSerializer(typeof(List<Figure>));
            using var filestream = File.OpenRead("C:\\Users\\Георгий\\source\\repos\\промышленное програмирование LUB1\\промышленное програмирование LUB1\\bin\\Debug\\net5.0\\figure.xml");
            Figures = (List<Figure>)xml.Deserialize(filestream);
        }

        public List<Figure> GetAll()
        {
            return this.Figures;
        }
    }
}
