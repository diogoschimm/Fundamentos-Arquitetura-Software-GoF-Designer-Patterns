using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryComputerProject
{
    public interface IComputerAbstractFactory
    {
        Computer CreateComputer();
    }
}
