using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MrEmilProjekt.Shapes
{
    public class ShapesMenu
    {
        
        public  int ShowShapesMenu()
        {

           

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                             ---------------------------------------------------");
            Console.WriteLine("                             |      ****         1:  Rektangel         ****     |");
            Console.WriteLine("                             |      ****         2:  Parallellogram    ****     |");
            Console.WriteLine("                             |      ****         3:  Triangel          ****     |");
            Console.WriteLine("                             |      ****         4:  Romb              ****     |");
            Console.WriteLine("                             |      ****         5:  Lista Shapes      ****     |");
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
