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
    public class ComparisonFigureCommand : Command<ComparisonFigureCommand.ComparisonFigureSettings>
    {
        private readonly IMenu _figure;

        public ComparisonFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] ComparisonFigureSettings settings)
        {
            if (_figure.Count() < 2)
            {
                AnsiConsole.Clear();
                AnsiConsole.WriteLine("Сравнение невозможно!");
                return 1;
            }
            _figure.Comparison(_figure.get_index(1, _figure.Count()) - 1, _figure.get_index(1, _figure.Count()) - 1);
            return 0;
        }

        public class ComparisonFigureSettings : CommandSettings
        {

        }
    }
}
