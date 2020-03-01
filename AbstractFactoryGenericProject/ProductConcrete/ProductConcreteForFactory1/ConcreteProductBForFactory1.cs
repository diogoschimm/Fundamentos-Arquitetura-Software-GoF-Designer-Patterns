using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory1
{
    public class ConcreteProductBForFactory1 : AbstractProductB
    {
        public override string ShowProductBName()
        {
            return "Concrete Product B For Factory 1";
        }
    }
}
