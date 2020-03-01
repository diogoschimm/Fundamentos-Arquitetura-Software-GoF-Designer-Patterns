using AbstractFactoryThemeProject.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryThemeProject.Concrete_Product
{
    public class ToolBarMagenta : ToolBarAbstract
    {
        public override string BackgroundColor()
        {
            return "Magenta";
        }

        public override string ForeColor()
        {
            return "Magenta";
        }
    }
}
