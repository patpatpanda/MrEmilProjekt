using MrEmilProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Data;

namespace MrEmilProjekt.Calculator
{
    internal class OperatorMenu
    {
        public void ChooseOperator()
        {
            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();
            var multiply = new Multiply(myContext);
            var subtraction = new Subtraction(myContext);
            var sqrt = new Sqrt(myContext);
            var divided = new Divided(myContext);
            var addition = new Addition(myContext);
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
            
            Console.WriteLine("                             |      ****        0: Mainmeny   ****    |");
            Console.WriteLine("                             ---------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Val : ");
            Console.ResetColor();
            var input = Console.ReadLine();

            if (input == "*")
            {
                multiply.MultiplyCalculator();
            }
            else if (input == "+") addition.AdditonCalculator();

                    else if (input == "-") subtraction.SubtractionCalculator();
                    else if (input == "/") divided.DividedCalculator();


                  
                    else if (input == "%") modulo.ModuloCalculator();
                   

                    else if (input == "0")
                    {
                        new Main().run();
                    }
        }

        
    }
}
