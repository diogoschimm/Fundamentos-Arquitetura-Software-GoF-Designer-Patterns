using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory2
{
    public class ConcreteProductBForFactory2 : AbstractProductB
    {
        public override string ShowProductBName()
        {
            return "Concrete Product B For Factory 2";
        }
    }
}
