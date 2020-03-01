using AbstractFactoryThemeProject.Abstract_Product;
using System.Collections.Generic;

namespace AbstractFactoryThemeProject.Concrete_Product
{
    public class ToolBarYellow : ToolBarAbstract
    { 
        public override string BackgroundColor()
        {
            return "DarkYellow";
        }

        public override string ForeColor()
        {
            return "DarkYellow";
        }
    }
}
