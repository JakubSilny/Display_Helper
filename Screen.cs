using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayClasses
{
    public class Screen
    {
        List<Label> Labels = new List<Label>();
        List<Element> elements = new List<Element>();
        public void ClearScreen()
        {
            Console.Clear();
        }


        public void RepaintScreen()
        {
            
            foreach (Label item in Labels)
            {
                if (item.background == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (item.background == "DarkBlue")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else if (item.background == "DarkGreen")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (item.background == "DarkCyan")
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else if (item.background == "DarkRed")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else if (item.background == "DarkMagenta")
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else if (item.background == "DarkYellow")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else if (item.background == "Gray")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else if (item.background == "DarkGray")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else if (item.background == "Blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (item.background == "Green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (item.background == "Cyan")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (item.background == "Red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (item.background == "Magenta")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (item.background == "Yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (item.background == "White")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                }
                //--------------------------------------------------------------
                if (item.foreground == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (item.foreground == "DarkBlue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (item.foreground == "DarkGreen")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (item.foreground == "DarkCyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (item.foreground == "DarkRed")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (item.foreground == "DarkMagenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (item.foreground == "DarkYellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (item.foreground == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (item.foreground == "DarkGray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (item.foreground == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (item.foreground == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item.foreground == "Cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (item.foreground == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (item.foreground == "Magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (item.foreground == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (item.foreground == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                }
                Console.SetCursorPosition(item.x,item.y);
                Console.Write(item.text);
            }

            foreach (Element item in elements)
            {
                if (item.background == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (item.background == "DarkBlue")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else if (item.background == "DarkGreen")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (item.background == "DarkCyan")
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else if (item.background == "DarkRed")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else if (item.background == "DarkMagenta")
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else if (item.background == "DarkYellow")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else if (item.background == "Gray")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else if (item.background == "DarkGray")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else if (item.background == "Blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (item.background == "Green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (item.background == "Cyan")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (item.background == "Red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (item.background == "Magenta")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (item.background == "Yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (item.background == "White")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                }
                //--------------------------------------------------------------
                if (item.foreground == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (item.foreground == "DarkBlue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (item.foreground == "DarkGreen")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (item.foreground == "DarkCyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (item.foreground == "DarkRed")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (item.foreground == "DarkMagenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (item.foreground == "DarkYellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (item.foreground == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (item.foreground == "DarkGray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (item.foreground == "Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (item.foreground == "Green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item.foreground == "Cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (item.foreground == "Red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (item.foreground == "Magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (item.foreground == "Yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (item.foreground == "White")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                }
                Console.SetCursorPosition(item.x, item.y);
                Console.Write(item.oobject);
            }
        }

        public void Clear()
        {
            Labels.Clear();
            elements.Clear();
        }

        public void AddLabel(Label _AddLabel)
        {
            Labels.Add(_AddLabel);
        }

        public void AddElement(Element _addelement)
        {
            elements.Add(_addelement);
        }
    }
}
