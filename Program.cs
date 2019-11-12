using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            
            Screen screen = new Screen();
            Label label = new Label(10, 11, 10, "Adámek", "Blue", "Red" );
            Element element = new Element(10, 2, 10, "7328");
            screen.AddLabel(label);
            screen.AddElement(element);
            
            screen.RepaintScreen();
            
            Console.ReadLine();
            
        }

        
    }
}
