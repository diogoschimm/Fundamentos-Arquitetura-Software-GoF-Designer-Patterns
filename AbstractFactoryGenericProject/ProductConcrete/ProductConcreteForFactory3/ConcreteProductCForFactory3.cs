using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory3
{
    public class ConcreteProductCForFactory3 : AbstractProductC
    {
        public override string ShowProductCName()
        {
            return "Concrete Product C For Factory 3";
        }
    }
}
