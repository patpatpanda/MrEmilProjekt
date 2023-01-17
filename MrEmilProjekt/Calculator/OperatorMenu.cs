using ClassLibrary2;
using MrEmilProjekt.Data;

namespace MrEmilProjekt.Calculator;

internal class OperatorMenu 
{
    public void ChooseOperator()
    {
        while (true)
        {
            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();
            var calc = new Calculator();
            var math = new MathOperators();
            var factory = new CalculationFactory(math,myContext,calc);
            


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

            Console.WriteLine("                             |      ****        0: Exit       ****    |");
            Console.WriteLine("                             ---------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Choice : ");
            Console.ResetColor();
            var input = Console.ReadLine();

            if (input == "*")
               factory.MultiplyCalculator();
            else if (input == "+") factory.AdditionCalculator();
            else if (input == "-") factory.SubtractionCalculator();
            else if (input == "/") factory.DividedCalculator(); 


            else if (input == "%") factory.ModuloCalculator();
            else if (input == "1") factory.SqrtCalculator();


            else if (input == "0")
            {

                break;
                var menu = new CalculatorMenu();
                menu.ShowCalculatorMenu();

            }

        }
        
        
    }
}