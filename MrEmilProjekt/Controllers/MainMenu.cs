using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Controllers
{
    public class MainMenu
    {
        public static int ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                             ---------------------------------------------------");
            Console.WriteLine("                             |      ****         1:  Shapes         ****       |");
            Console.WriteLine("                             |      ****         2:  Miniräknare    ****       |");
            Console.WriteLine("                             |      ****         3:  Sten,Sax,Påse  ****       |");
            Console.WriteLine("                             ----------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Val : ");
            Console.ResetColor();
            var inuput = int.Parse(Console.ReadLine());

            return inuput;
        }
    }
}
