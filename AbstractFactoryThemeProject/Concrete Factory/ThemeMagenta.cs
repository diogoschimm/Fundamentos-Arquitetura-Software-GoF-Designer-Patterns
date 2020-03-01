using AbstractFactoryThemeProject.Abstract_Factory;
using AbstractFactoryThemeProject.Abstract_Product;
using AbstractFactoryThemeProject.Concrete_Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryThemeProject.Concrete_Factory
{
    public class ThemeMagenta : ThemeFactory
    {
        public ThemeMagenta() : base("Magenta") { }

        public override DialogAbstract CriarDialog()
        {
            return new DialogMagenta();
        }

        public override ToolBarAbstract CriarToolBar()
        {
            return new ToolBarMagenta();
        }
    }
}
