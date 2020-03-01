using AbstractFactoryThemeProject.Abstract_Product;
using System.Collections.Generic;

namespace AbstractFactoryThemeProject.Concrete_Product
{
    public class ToolBarGreen : ToolBarAbstract
    {  
        public override string BackgroundColor()
        {
            return "DarkGreen";
        }

        public override string ForeColor()
        {
            return "DarkGreen";
        }
    }
}
