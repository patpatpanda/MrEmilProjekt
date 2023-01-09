
using MrEmilProjekt.Calculator;
using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;

namespace MrEmilProjekt;

public class Main
{
    public void run()
    {
        // var Variabel = 64; 
        //var hej = System.Math.Sqrt(Variabel);
        // Console.WriteLine(hej);
        // Console.ReadLine();
        var buildApp = new Builder();
        var myContext = buildApp.AppBuilder();

        while (true)
        {
            try
            {
                var input = MainMenu.ShowMenu();
                if (input == 1)
                {
                    var test = new ShapesMenu();
                    test.ShowShapesMenu();


                }
                else if (input == 2)
                {
                    var test = new CalculatorMenu();
                    test.ShowCalculatorMenu();


                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("\nTryck enter för att fortsäta");
                Console.ReadLine();
            }
        }

        
    }
}