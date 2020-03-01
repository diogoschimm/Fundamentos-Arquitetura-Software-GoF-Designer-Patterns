using AbstractFactoryGenericProject.FactoryAbstract;
using AbstractFactoryGenericProject.ProductAbstract;
using AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory3;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.FactoryConcrete
{
    public class ConcreteFactory3 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductAForFactory3();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductBForFactory3();
        }

        public override AbstractProductC CreateProductC()
        {
            return new ConcreteProductCForFactory3();
        }
    }
}
