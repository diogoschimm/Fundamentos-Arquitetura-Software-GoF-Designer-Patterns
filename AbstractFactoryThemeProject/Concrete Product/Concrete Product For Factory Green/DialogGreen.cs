using AbstractFactoryThemeProject.Abstract_Product;

namespace AbstractFactoryThemeProject.Concrete_Product
{
    public class DialogGreen : DialogAbstract
    { 
        public override string BackgroundColor()
        {
            return "Green";
        }

        public override string ForeColor()
        {
            return "Green";
        }
    }
}
