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
            CalculationFactory factory = new CalculationFactory();
            
            var createCalculation = new CreateCalculation(factory,myContext);
            
            
          
            
           
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
                createCalculation.MultiplyCalculator();
            }
            else if (input == "+") createCalculation.AdditonCalculator();
            else if (input == "-") createCalculation.SubtractionCalculator();
            else if (input == "/") createCalculation.DividedCalculator();


            else if (input == "%") createCalculation.ModuloCalculator();
            else if(input == "1") createCalculation.SqrtCalculator();
                   

                    else if (input == "0")
                    {
                        new Main().run();
                    }
        }

        
    }
}
