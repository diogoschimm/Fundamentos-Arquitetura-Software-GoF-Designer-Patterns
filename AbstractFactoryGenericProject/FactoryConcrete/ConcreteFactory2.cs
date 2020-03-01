using AbstractFactoryGenericProject.FactoryAbstract;
using AbstractFactoryGenericProject.ProductAbstract;
using AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.FactoryConcrete
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductAForFactory2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductBForFactory2();
        }

        public override AbstractProductC CreateProductC()
        {
            return new ConcreteProductCForFactory2();
        }
    }
}
