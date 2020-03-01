using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory2
{
    public class ConcreteProductCForFactory2 : AbstractProductC
    {
        public override string ShowProductCName()
        {
            return "Concrete Product C For Factory 2";
        }
    }
}
