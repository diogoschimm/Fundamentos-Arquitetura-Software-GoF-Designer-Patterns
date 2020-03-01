using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory2
{
    public class ConcreteProductAForFactory2 : AbstractProductA
    {
        public override string ShowProductAName()
        {
            return "Concrete Product A For Factory 2";
        }
    }
}
