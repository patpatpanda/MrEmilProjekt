using MrEmilProjekt.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Data;
using MrEmilProjekt.Migrations;
using System.Xml;

namespace MrEmilProjekt.Calculator
{
    public class CalculatorMenu
    {


        public void ShowCalculatorMenu()
        {
            while (true)
            {
                try
                {
                    var buildApp = new Builder();
                    var myContext = buildApp.AppBuilder();
                    var controllerCalc = new CalculatorController(myContext);
                    var makeCalculation = new OperatorMenu();



                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("                                    ********  MENU  *******");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                             --------------------------------------------");
                    Console.WriteLine("                             |     ***  1 : Make Calculation   ****    |");
                    Console.WriteLine("                             |     ***  2 : List all           ****    |");
                    Console.WriteLine("                             |     ***  3 : Delete             ****    |");
                    Console.WriteLine("                             |     ***  4 : Update             ****    |");
                   
                    Console.WriteLine("                             |     ***   0: Mainmeny            ****   |");
                    Console.WriteLine("                             ---------------------------------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("                                                Val : ");
                    Console.ResetColor();
                    var input = int.Parse(Console.ReadLine());
                    

                    if (input == 1) makeCalculation.ChooseOperator();



                    else if (input == 2)
                    {
                        controllerCalc.ListCalculator();
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadLine();
                }
               //
                   
            }
        }
    }
}
