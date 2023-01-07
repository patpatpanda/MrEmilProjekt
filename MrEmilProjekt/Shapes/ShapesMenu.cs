using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Data;
using MrEmilProjekt.Migrations;


namespace MrEmilProjekt.Shapes
{
    public class ShapesMenu
    {

       
        public int ShowShapesMenu()
        {
            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();
            var createShape = new CreateShape(myContext);
            var readShape = new ShapeController(myContext);

            

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                             ---------------------------------------------------");
            Console.WriteLine("                             |      ****         1:  Rektangel         ****     |");
            Console.WriteLine("                             |      ****         2:  Parallellogram    ****     |");
            Console.WriteLine("                             |      ****         3:  Triangel          ****     |");
            Console.WriteLine("                             |      ****         4:  Romb              ****     |");
            Console.WriteLine("                             |      ****         5:  Lista Shapes      ****     |");
            Console.WriteLine("                             |      ****         6:  Lista Shapes      ****     |");
            Console.WriteLine("                             ----------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Val : ");
            Console.ResetColor();
            var inuput = int.Parse(Console.ReadLine());
            if(inuput == 5) readShape.ListShape();
            return inuput;

        }
    }
}
