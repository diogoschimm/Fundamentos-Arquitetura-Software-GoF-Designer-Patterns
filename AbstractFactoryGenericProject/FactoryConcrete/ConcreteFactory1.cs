using AbstractFactoryGenericProject.FactoryAbstract;
using AbstractFactoryGenericProject.ProductAbstract;
using AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.FactoryConcrete
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductAForFactory1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductBForFactory1();
        }

        public override AbstractProductC CreateProductC()
        {
            return new ConcreteProductCForFactory1();
        }
    }
}
