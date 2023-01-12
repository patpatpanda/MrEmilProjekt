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
            var factory = new CalculationFactory(calc, math);
            var createCalculation = new CreateCalculation(factory, myContext);


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
                createCalculation.MultiplyCalculator();
            else if (input == "+") createCalculation.AdditionCalculator();
            else if (input == "-") createCalculation.SubtractionCalculator();
            else if (input == "/") createCalculation.DividedCalculator();


            else if (input == "%") createCalculation.ModuloCalculator();
            else if (input == "1") createCalculation.SqrtCalculator();


            else if (input == "0")
            {

                break;
                var menu = new CalculatorMenu();
                menu.ShowCalculatorMenu();

            }

        }
        
        
    }
}