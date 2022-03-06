using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace промышленное_програмирование_LUB1.Command
{
    public class PerimeterFigureCommand : Command<PerimeterFigureCommand.PerimeterFigureSettings>
    {
        private readonly IMenu _figure;

        public PerimeterFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] PerimeterFigureSettings settings)
        {
            if (_figure.Count() == 0)
            {
                AnsiConsole.WriteLine("Колекция пуста");
                return 1;
            }
            int index = _figure.get_index(1, _figure.Count()) - 1;
            AnsiConsole.WriteLine($"{_figure.GetAll()[index]} Perimeter = {_figure.perimeter(index)}");
            return 0;
        }

        public class PerimeterFigureSettings : CommandSettings
        {

        }
    }
}