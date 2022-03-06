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
    public class FramingRectangleFigureCommand : Command<FramingRectangleFigureCommand.FramingRectangleFigureSettings>
    {
        private readonly IMenu _figure;

        public FramingRectangleFigureCommand(IMenu figure)
        {
            _figure = figure;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] FramingRectangleFigureSettings settings)
        {

            if (_figure.Count() == 0)
            {
                AnsiConsole.WriteLine("Колекция пуста");
                return 1;
            }
            int index = _figure.get_index(1, _figure.Count()) - 1;

            var obj = _figure.GetAll()[index].framing_rectangle();
            AnsiConsole.WriteLine(obj.ToString());
            var str = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("[green]Добавить в коллекцию обрамляющий прямоугольник: [/]")
                .AddChoices("да", "нет"));
            switch (str)
            {
                case "да":
                    _figure.Add(_figure.get_index(1, _figure.Count()) - 1, obj);
                    break;
                case "нет":
                    break;
            }
            _figure.Serialize();
            return 0;

        }

        public class FramingRectangleFigureSettings : CommandSettings
        {

        }
    }
}
