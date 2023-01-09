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
                try
                {
                    var buildApp = new Builder();
                    var myContext = buildApp.AppBuilder();
                    var multiply = new Multiply(myContext);
                    var subtraction = new Subtraction(myContext);
                    var sqrt = new Sqrt(myContext);
                    var divided = new Divided(myContext);
                    var modulo = new Modulo(myContext);
                    var controllerCalc = new CalculatorController(myContext);


                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("                                    ********  VÄLJ OPERATOR *******");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                             --------------------------------------------");
                    Console.WriteLine("                             |      ****           +          ****    |");
                    Console.WriteLine("                             |      ****           -          ****    |");
                    Console.WriteLine("                             |      ****           /          ****    |");
                    Console.WriteLine("                             |      ****           *          ****    |");
                    Console.WriteLine("                             |      ****        1: √          ****    |");
                    Console.WriteLine("                             |      ****           %          ****    |");
                    Console.WriteLine("                             |      ****        2: ListAll    ****    |");
                    Console.WriteLine("                             |      ****        0: Mainmeny   ****    |");
                    Console.WriteLine("                             ---------------------------------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("                                                    Val : ");
                    Console.ResetColor();
                    var inuput = Console.ReadLine();

                    if (inuput == "+")
                    {
                        multiply.MultiplyCalculator();
                    }

                    else if (inuput == "-") subtraction.SubtractionCalculator();
                    else if (inuput == "/") divided.DividedCalculator();


                    else if (inuput == "S") sqrt.SqrtCalculator();
                    else if (inuput == "%") modulo.ModuloCalculator();
                    else if(inuput == "2")  controllerCalc.ListCalculator();

                    else if (inuput == "0")
                    {
                        new Main().run();
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
