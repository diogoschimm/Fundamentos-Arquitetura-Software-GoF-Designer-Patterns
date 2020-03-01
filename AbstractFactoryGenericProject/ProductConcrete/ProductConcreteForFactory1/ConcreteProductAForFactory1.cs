using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory1
{
    public class ConcreteProductAForFactory1 : AbstractProductA
    {
        public override string ShowProductAName()
        {
            return "Concrete Product A For Factory 1";
        }
    }
}
