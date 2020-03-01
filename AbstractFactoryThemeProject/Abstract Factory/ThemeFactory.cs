using AbstractFactoryThemeProject.Abstract_Product;

namespace AbstractFactoryThemeProject.Abstract_Factory
{
    public abstract class ThemeFactory
    {
        public string Name { get; private set; }

        protected ThemeFactory(string name)
        {
            this.Name = name;
        }

        public abstract ToolBarAbstract CriarToolBar();
        public abstract DialogAbstract CriarDialog();
    }
}
