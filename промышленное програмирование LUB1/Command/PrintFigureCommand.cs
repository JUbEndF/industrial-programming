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
    public class PrintFigureCommand:Command<PrintFigureCommand.PrintFigureSettings>
    {
        private readonly IMenu _figure;

        public PrintFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] PrintFigureSettings settings)
        {
            var table = new Table();
            table.AddColumn("Type");
            table.AddColumn("Element's");
            table.AddColumn("Squere");
            table.AddColumn("Leght");
            foreach (var obj in _figure.GetAll())
            {
                table.AddRow(obj.GetType().Name, obj.ToString(), obj.square().ToString(), obj.perimeter().ToString());
                if (table.Rows.Count() == 10)
                {
                    table.AddRow("...", "...", "...", "...");
                    break;
                }
            }
            AnsiConsole.Write(table);
            return 0;
        }

        public class PrintFigureSettings:CommandSettings
        {

        }
    }
}
