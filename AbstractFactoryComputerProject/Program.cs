using System;

namespace AbstractFactoryComputerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer pc =ComputerFactory.GetComputer(new PCFactory("2 GB", "500 GB", "2.4 GHz"));
            Computer server =  ComputerFactory.GetComputer(new ServerFactory("16 GB", "1 TB", "2.9 GHz"));

            Console.WriteLine("AbstractFactory PC Config::" + pc);
            Console.WriteLine("AbstractFactory Server Config::" + server);

            Console.ReadKey();
        }
    }
}
