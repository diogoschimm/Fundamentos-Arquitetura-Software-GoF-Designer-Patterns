using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryComputerProject
{
    public class PC : Computer
    {
        private readonly string ram;
        private readonly string hdd;
        private readonly string cpu;

        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string GetCPU()
        {
            return this.cpu;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRAM()
        {
            return this.ram;
        }
    }
}
