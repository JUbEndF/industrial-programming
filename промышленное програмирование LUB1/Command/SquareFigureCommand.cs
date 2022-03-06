using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace промышленное_програмирование_LUB1.Command
{
    public class SquareFigureCommand : Command<SquareFigureCommand.SquareFigureSettings>
    {
        private readonly IMenu _figure;

        public SquareFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] SquareFigureSettings settings)
        {
            if (_figure.Count() == 0)
            {
                AnsiConsole.WriteLine("Колекция пуста");
                return 1;
            }
            int index = _figure.get_index(1, _figure.Count()) - 1;
            AnsiConsole.WriteLine($"{_figure.GetAll()[index]} squeare = {_figure.Squere(index)}");
            return 0;

        }

        public class SquareFigureSettings : CommandSettings
        {

        }
    }
}
