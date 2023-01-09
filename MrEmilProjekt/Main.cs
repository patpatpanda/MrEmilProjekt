
using MrEmilProjekt.Calculator;
using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;

namespace MrEmilProjekt;

public class Main
{
    public void run()
    {
       
        var buildApp = new Builder();
        var myContext = buildApp.AppBuilder();

        while (true)
        {
            try
            {
                var input = MainMenu.ShowMenu();
                if (input == 1)
                {
                    new ShapesMenu().ShowShapesMenu();


                }
                else if (input == 2)
                {
                    new CalculatorMenu().ShowCalculatorMenu();


                }
                else if (input == 0) break;
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Incorrect input");
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                
            }
            

           
           
        }

        
    }
}