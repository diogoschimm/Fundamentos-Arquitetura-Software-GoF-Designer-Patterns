using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory3
{
    public class ConcreteProductBForFactory3 : AbstractProductB
    {
        public override string ShowProductBName()
        {
            return "Concrete Product B For Factory 3";
        }
    }
}
