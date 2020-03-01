using AbstractFactoryGenericProject.FactoryAbstract;
using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.Client
{
    public class ClientCore
    {
        private AbstractFactory _abstractFactory;

        public AbstractProductA AbstractProductA { get; private set; }
        public AbstractProductB AbstractProductB { get; private set; }
        public AbstractProductC AbstractProductC { get; private set; }

        public void Run(AbstractFactory abstractFactory)
        {
            this._abstractFactory = abstractFactory;

            this.AbstractProductA = _abstractFactory.CreateProductA();
            this.AbstractProductB = _abstractFactory.CreateProductB();
            this.AbstractProductC = _abstractFactory.CreateProductC();

            Console.WriteLine(".... " + this.AbstractProductA.ShowProductAName());
            Console.WriteLine(".... " + this.AbstractProductB.ShowProductBName());
            Console.WriteLine(".... " + this.AbstractProductC.ShowProductCName());
        }
    }
}
