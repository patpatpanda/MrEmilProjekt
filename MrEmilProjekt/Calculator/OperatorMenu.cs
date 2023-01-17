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
               factory.MultiplyMaker();
            else if (input == "+") factory.AdditionMaker();
            else if (input == "-") factory.SubtractionMaker();
            else if (input == "/") factory.DividedMaker(); 


            else if (input == "%") factory.ModuloMaker();
            else if (input == "1") factory.SqrtMaker();


            else if (input == "0")
            {

                break;
                var menu = new CalculatorMenu();
                menu.ShowCalculatorMenu();

            }

        }
        
        
    }
}