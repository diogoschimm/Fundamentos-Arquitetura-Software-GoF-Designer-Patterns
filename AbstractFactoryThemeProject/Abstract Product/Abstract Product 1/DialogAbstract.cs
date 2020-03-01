using System;

namespace AbstractFactoryThemeProject.Abstract_Product
{
    public abstract class DialogAbstract
    {  
        public abstract string BackgroundColor();
        public abstract string ForeColor();

        public void ShowMessage(string title, string message)
        { 
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), this.ForeColor());

            Console.WriteLine($"Title = {title}");
            Console.WriteLine($"Message = {message}");
        }
    }
}
