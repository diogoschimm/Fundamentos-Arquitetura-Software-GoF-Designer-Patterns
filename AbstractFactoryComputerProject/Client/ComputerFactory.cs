using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryComputerProject
{
    public class ComputerFactory
    {
        public static Computer GetComputer(IComputerAbstractFactory factory)
        {
            return factory.CreateComputer();
        }
    }
}
