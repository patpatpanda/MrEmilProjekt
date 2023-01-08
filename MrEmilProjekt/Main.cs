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