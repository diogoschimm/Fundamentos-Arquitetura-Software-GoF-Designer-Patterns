using AbstractFactoryGenericProject.Client;
using AbstractFactoryGenericProject.FactoryConcrete;
using System;

namespace AbstractFactoryGenericProject
{
    class Program
    {
        static void Main()
        {
            var client = new ClientCore();

            Console.WriteLine("");
            Console.WriteLine("Utilizando a Factory 1:");
                       
            var factory1 = new ConcreteFactory1();
            client.Run(factory1);

            Console.WriteLine("");
            Console.WriteLine("Utilizando a Factory 2:");

            var factory2 = new ConcreteFactory2();
            client.Run(factory2);

            Console.WriteLine("");
            Console.WriteLine("Utilizando a Factory 3:");

            var factory3 = new ConcreteFactory3();
            client.Run(factory3);

        }
    }
}
