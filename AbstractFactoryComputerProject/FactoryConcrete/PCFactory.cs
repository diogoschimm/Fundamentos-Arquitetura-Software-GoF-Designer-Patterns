using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryComputerProject
{
    public class PCFactory : IComputerAbstractFactory
    {
		private readonly string ram;
		private readonly string hdd;
		private readonly string cpu;

		public PCFactory(string ram, string hdd, string cpu)
		{
			this.ram = ram;
			this.hdd = hdd;
			this.cpu = cpu;
		}
		public Computer CreateComputer()
        {
			return new PC(ram, hdd, cpu);
        }
    }
}
