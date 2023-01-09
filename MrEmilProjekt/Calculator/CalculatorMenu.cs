using MrEmilProjekt.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Data;
using MrEmilProjekt.Migrations;

namespace MrEmilProjekt.Calculator
{
    public class CalculatorMenu
    {


        public void ShowCalculatorMenu()
        {
            while (true)
            {

                var buildApp = new Builder();
                var myContext = buildApp.AppBuilder();
                var multiply = new Multiply(myContext);
                var subtraction = new Subtraction(myContext);



                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("                             ----------------------------------");
                Console.WriteLine("                             |      ****         1:  +          ****|");
                Console.WriteLine("                             |      ****         2:  -          ****|");
                Console.WriteLine("                             |      ****         3:  *          ****|");
                Console.WriteLine("                             |      ****         4:  /          ****|");
                Console.WriteLine("                             |      ****         5:  √          ****|");
                Console.WriteLine("                             |      ****         6:  Mainmeny   ****|");
                Console.WriteLine("                             -----------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("                                                    Val : ");
                Console.ResetColor();
                var inuput = int.Parse(Console.ReadLine());

                if (inuput == 1)
                {
                   multiply.MultuplyCalculator();
                }
                else if(inuput == 2)  subtraction.SubtractionCalculator();
            }
        }
    }
}
