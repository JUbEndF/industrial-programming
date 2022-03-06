using Lab1.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using Spectre.Console.Cli;
using System;
using System.Xml;
using System.Xml.Serialization;
using промышленное_програмирование_LUB1.Command;
using промышленное_програмирование_LUB1.model;
namespace промышленное_програмирование_LUB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Command
            var serviseCollection = new ServiceCollection();

            serviseCollection.AddSingleton<IMenu, Menu>();

            var registr = new TypeRegistrar(serviseCollection);
            var app = new CommandApp(registr);

            app.Configure(config =>
            {
                config.AddCommand<AddFigureCommand>("add");
                config.AddCommand<PrintFigureCommand>("print");
                config.AddCommand<RemuveFigureCommand>("remuve");
                config.AddCommand<ComparisonFigureCommand>("comparison");
                config.AddCommand<FramingRectangleFigureCommand>("framingrectang");
                config.AddCommand<PerimeterFigureCommand>("perimeter");
                config.AddCommand<SquareFigureCommand>("squeare");
            });
            app.Run(args);




            //Menu
            //var figure = new Menu();
            //do
            //{
            //    var str = AnsiConsole.Prompt(new SelectionPrompt<string>()
            //    .Title("[green]Меню: [/]")
            //    .AddChoices("cоздание объекта",
            //    "сравнение двух объектов по указанным индексам",
            //    "вывод контейнера на экран",
            //    "Вывести общую площадь всех фигур",
            //    "Площадь фигуры по индуксу",
            //    "Периметр фигуры по индуксу",
            //    "удаление объекта из коллекции по индексу",
            //    "удаление всех объектов из коллекции",
            //    "Выйти"));
            //    switch (str)
            //    {
            //        case "cоздание объекта":
            //            int index = figure.Count() != 0 ? figure.get_index(1, figure.Count() + 1) - 1 : 0;
            //            figure.create_new_figure(index);
            //            Console.ReadKey();
            //            break;
            //        case "удаление объекта из коллекции по индексу":
            //            if (figure.Count() == 0)
            //            {
            //                AnsiConsole.Clear();
            //                AnsiConsole.WriteLine("Колекция пуста");
            //                break;
            //            }
            //            figure.Remuve_element(figure.get_index(1, figure.Count()) - 1);
            //            Console.ReadKey();
            //            break;
            //        case "удаление всех объектов из коллекции":
            //            if (figure.Count() == 0)
            //            {
            //                AnsiConsole.Clear();
            //                AnsiConsole.WriteLine("Колекция пуста");
            //                break;
            //            }
            //            figure.Remuve();
            //            Console.ReadKey();
            //            break;
            //        case "сравнение двух объектов по указанным индексам":
            //            if (figure.Count() < 2)
            //            {
            //                AnsiConsole.Clear();
            //                AnsiConsole.WriteLine("Сравнение невозможно!");
            //                break;
            //            }
            //            figure.Comparison(figure.get_index(1, figure.Count()) - 1, figure.get_index(1, figure.Count()) - 1);
            //            Console.ReadKey();
            //            break;
            //        case "вывод контейнера на экран":
            //            figure.Print();
            //            Console.ReadKey();
            //            break;
            //        case "Вывести общую площадь всех фигур":
            //            figure.Print_Squere();
            //            Console.ReadKey();
            //            break;
            //        case "Периметр фигуры по индуксу":
            //            index = figure.get_index(1, figure.Count()) - 1;
            //            figure.PrintElement(index);
            //            figure.Squere(index);
            //            Console.ReadKey();
            //            return;
            //        case "Площадь фигуры по индуксу":
            //            index = figure.get_index(1, figure.Count()) - 1;
            //            figure.PrintElement(index);
            //            figure.Squere(index);
            //            Console.ReadKey();
            //            Console.ReadKey();
            //            return;
            //        case "Выйти":
            //            figure.Serialize();
            //            return;
            //    }
            //    AnsiConsole.Clear();
            //} while (true);
        }
    }
}
