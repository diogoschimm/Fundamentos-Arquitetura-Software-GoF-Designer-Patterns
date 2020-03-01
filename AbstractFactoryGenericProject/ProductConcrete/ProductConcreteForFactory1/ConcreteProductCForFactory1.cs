using AbstractFactoryGenericProject.ProductAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryGenericProject.ProductConcrete.ProductConcreteForFactory1
{
    public class ConcreteProductCForFactory1 : AbstractProductC
    {
        public override string ShowProductCName()
        {
            return "Concrete Product C For Factory 1";
        }
    }
}
