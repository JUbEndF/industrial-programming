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
    public class RemuveFigureCommand:Command<RemuveFigureCommand.RemuveFigureSettings>
    {
        private readonly IMenu _figure;

        public RemuveFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] RemuveFigureSettings settings)
        {
            if (_figure.Count() == 0)
            {
                AnsiConsole.WriteLine("Колекция пуста");
                return 1;
            }
            var str = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("[green]Удаление: [/]")
                .AddChoices("Один объект", "Все элементы"));
            switch (str)
            {
                case "Один объект":
                    _figure.Remuve_element(_figure.get_index(1, _figure.Count()) - 1);
                    break;
                case "Все элементы":
                    _figure.Remuve();
                    break;
            }
            _figure.Serialize();
            return 0;
        }

        public class RemuveFigureSettings:CommandSettings
        {

        }
    }
}
