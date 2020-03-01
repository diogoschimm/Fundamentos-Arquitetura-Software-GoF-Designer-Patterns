using AbstractFactoryThemeProject.Abstract_Product;

namespace AbstractFactoryThemeProject.Concrete_Product
{
    public class DialogYellow : DialogAbstract
    { 
        public override string BackgroundColor()
        {
            return "Yellow";
        }

        public override string ForeColor()
        {
            return "Yellow";
        }
    }
}
