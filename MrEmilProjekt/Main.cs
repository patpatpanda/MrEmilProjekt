
using MrEmilProjekt.Calculator;
using MrEmilProjekt.Data;
using MrEmilProjekt.Game;
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
                else if (input == 3)
                {
                    new CreateGame().PlayGame();
                }
                else if (input == 0)
                {
                    Console.Clear();
                    Console.WriteLine("BYE!!!!!!!!!!!!!!!!");
                    Console.WriteLine("BYE!!!!!!!!!!!!!!!!");
                    break;
                }
            }

            catch(Exception e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress Any Key To Continue");
                Console.ReadKey();
            }
            

           //
           
        }

        
    }
}