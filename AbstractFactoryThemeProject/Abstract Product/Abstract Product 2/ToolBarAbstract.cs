using System;
using System.Collections.Generic;

namespace AbstractFactoryThemeProject.Abstract_Product
{
    public abstract class ToolBarAbstract
    {
        protected IList<string> Itens { get; private set; }

        public ToolBarAbstract()
        {
            this.Itens = new List<string>();

            this.Itens.Add("File");
            this.Itens.Add("Edit");
            this.Itens.Add("View");
            this.Itens.Add("Project");
        }

        public abstract string BackgroundColor();
        public abstract string ForeColor();

        public void ShowToolBar()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), this.ForeColor());
            foreach (var item in this.Itens)
            {
                Console.WriteLine(item);
            }
        }
    }
}
