using AbstractFactoryThemeProject.Abstract_Factory;
using AbstractFactoryThemeProject.Abstract_Product;
using AbstractFactoryThemeProject.Concrete_Product;
using System.Collections.Generic;

namespace AbstractFactoryThemeProject.Concrete_Factory
{
    public class ThemeYellow : ThemeFactory
    {
        public ThemeYellow() : base("Dark") { }

        public override DialogAbstract CriarDialog()
        {
            return new DialogYellow();
        }

        public override ToolBarAbstract CriarToolBar()
        {
            return new ToolBarYellow();
        }
    }
}
