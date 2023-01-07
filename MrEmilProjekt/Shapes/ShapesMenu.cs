﻿using Microsoft.EntityFrameworkCore;
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

       
        public void ShowShapesMenu()
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
            Console.WriteLine("                             |      ****         6:  Update Shapes     ****     |");
            Console.WriteLine("                             |      ****         7:  Delete Shapes     ****     |");
            Console.WriteLine("                             |      ****         0:  Huvudmeny         ****     |");
            Console.WriteLine("                             ----------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Val : ");
            Console.ResetColor();
            var inuput = int.Parse(Console.ReadLine());

            if (inuput == 1) createShape.RektangelFormManeger();


            else if (inuput == 2) createShape.ParaelleogramManeger();


            else if (inuput == 3) createShape.TriangelManeger();
            else if (inuput == 4) createShape.RombManeger();
            else if (inuput == 5) readShape.ListShape();
            else if(inuput == 6) readShape.UpdateShape();
            else if(inuput == 7) readShape.DeleteShape();
            else if (inuput == 0)
            {
                var menu = new Main();
                menu.run();

            }
            
                
            
            
                
            
            

        }
    }
}
