using Spectre.Console;
using Spectre.Console.Cli;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using промышленное_програмирование_LUB1.model;

namespace промышленное_програмирование_LUB1.Command
{
    public class AddFigureCommand:Command<AddFigureCommand.AddFigureSettings>
    {
        private readonly IMenu _figure;

        public AddFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] AddFigureSettings settings)
        {
            int index = _figure.Count() != 0 ? _figure.get_index(1, _figure.Count() + 1) - 1 : 0;
            var str = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("[green]Выберете тип создаваемой фигкры: [/]")
                .AddChoices("Прямоугольник", "Треугольник", "Круг"));
            switch (str)
            {
                case "Прямоугольник":
                    AnsiConsole.WriteLine("Координата A");
                    var A = _figure.create_point();
                    AnsiConsole.WriteLine("Координата B");
                    var B = _figure.create_point();
                    Figure obj = new Rectangle(A, B);
                    _figure.Add(index, obj);
                    break;
                case "Треугольник":
                    AnsiConsole.WriteLine("Координата A");
                    A = _figure.create_point();
                    AnsiConsole.WriteLine("Координата B");
                    B = _figure.create_point();
                    AnsiConsole.WriteLine("Координата C");
                    var C = _figure.create_point();
                    obj = new Triangle(A, B, C);
                    _figure.Add(index, obj);
                    break;
                case "Круг":
                    AnsiConsole.WriteLine("Координата центра");
                    A = _figure.create_point();
                    AnsiConsole.WriteLine("Радиус окружности");
                    double R;
                    do
                        R = AnsiConsole.Prompt(new TextPrompt<double>("[Green]Введите вещественный радиус(0, +Б): [/]"));
                    while (R <= 0);
                    obj = new Circle(A, R);
                    _figure.Add(index, obj);
                    break;
            }
            _figure.Serialize();
            return 1;

        }

        public class AddFigureSettings:CommandSettings
        {

        }
    }
}
