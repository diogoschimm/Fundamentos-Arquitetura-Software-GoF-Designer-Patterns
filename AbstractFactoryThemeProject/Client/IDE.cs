using AbstractFactoryThemeProject.Abstract_Factory;
using AbstractFactoryThemeProject.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryThemeProject.Client
{
    public class IDE
    {
        private ThemeFactory _themeFactory;

        public DialogAbstract Dialog { get; private set; }
        public ToolBarAbstract ToolBar { get; private set; }

        public IDE(ThemeFactory themeFactory)
        {
            this._themeFactory = themeFactory;
        }

        public void Run()
        { 
            this.Dialog = _themeFactory.CriarDialog();
            this.ToolBar = _themeFactory.CriarToolBar();

            Console.WriteLine("");
            this.Dialog.ShowMessage("Mensagem do Sistema", "Bem-vindo a IDE");

            Console.WriteLine("");
            this.ToolBar.ShowToolBar(); 
        }
    }
}
