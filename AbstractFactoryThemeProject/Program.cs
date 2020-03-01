using AbstractFactoryThemeProject.Client;
using AbstractFactoryThemeProject.Concrete_Factory;
using System;

namespace AbstractFactoryThemeProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha seu Tema (Abstract Factory)");
            Console.WriteLine("");
            Console.WriteLine("  1 - Yellow ");
            Console.WriteLine("  2 - Green ");
            Console.WriteLine("  3 - Magenta ");

            var theme = Console.ReadLine();
            switch (theme)
            {
                case "1":
                    new IDE(new ThemeYellow()).Run();
                    break;
                case "2":
                    new IDE(new ThemeGreen()).Run();
                    break;
                case "3":
                    new IDE(new ThemeMagenta()).Run();
                    break;
                default:
                    Console.WriteLine("Tema inválido");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
