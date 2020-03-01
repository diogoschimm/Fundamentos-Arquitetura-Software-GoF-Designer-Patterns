using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryComputerProject
{
    public abstract class Computer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();

        public override string ToString()
        {
            return "RAM= " + this.GetRAM() + ", HDD=" + this.GetHDD() + ", CPU=" + this.GetCPU();
        }
    }
}
