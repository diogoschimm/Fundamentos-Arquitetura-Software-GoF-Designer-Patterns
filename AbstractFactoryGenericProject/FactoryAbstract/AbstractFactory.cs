using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.FactoryAbstract
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA(); 
        public abstract AbstractProductB CreateProductB();
        public abstract AbstractProductC CreateProductC();
    }
}
