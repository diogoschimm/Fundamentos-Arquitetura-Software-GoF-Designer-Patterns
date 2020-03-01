using AbstractFactoryThemeProject.Abstract_Factory;
using AbstractFactoryThemeProject.Abstract_Product;
using AbstractFactoryThemeProject.Concrete_Product;
using System.Collections.Generic;

namespace AbstractFactoryThemeProject.Concrete_Factory
{
    public class ThemeGreen : ThemeFactory
    {
        public ThemeGreen() : base("Light") { }

        public override DialogAbstract CriarDialog()
        {
            return new DialogGreen();
        }

        public override ToolBarAbstract CriarToolBar()
        {
            return new ToolBarGreen();
        }
    }
}
