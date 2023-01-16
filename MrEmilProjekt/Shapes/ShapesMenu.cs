using ClassLibrary2;
using MrEmilProjekt.Data;

namespace MrEmilProjekt.Shapes;

public class ShapesMenu
{
    public void ShowShapesMenu()
    {
        while (true)
        {
            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();

            var shapeService = new ShapeServices();
            var shape = new Shape();
            var factory = new ShapeFactory(shape, shapeService, myContext);
            var controller = new ShapeController(myContext);


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(
                "                             -------------------------------------------------------");
            Console.WriteLine(
                "                             |      ****         1:  Create Rectangle         **** |");
            Console.WriteLine(
                "                             |      ****         2:  Create Parallellogram    **** |");
            Console.WriteLine(
                "                             |      ****         3:  Create Triangele         **** |");
            Console.WriteLine(
                "                             |      ****         4:  Create Romb              **** |");
            Console.WriteLine(
                "                             |      ****         5:  List                     **** |");
            Console.WriteLine(
                "                             |      ****         6:  Update                   **** |");
            Console.WriteLine(
                "                             |      ****         7:  Delete                   **** |");
            Console.WriteLine(
                "                             |      ****         0:  Mainmenu                 **** |");
            Console.WriteLine("                             ----------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                          Choice : ");
            Console.ResetColor();
            var inuput = int.Parse(Console.ReadLine());

            if (inuput == 1)
            {
                factory.CreateRectangle();
            }


            else if (inuput == 2)
            {
                factory.CreateParaellogram();
            }


            else if (inuput == 3)
            {
                factory.CreateTriangle();
            }
            else if (inuput == 4)
            {
                factory.CreateRomb();
            }
            else if (inuput == 5)
            {
                controller.ListShape();
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            else if (inuput == 6)
            {
                controller.UpdateShape();
            }
            else if (inuput == 7)
            {
                controller.DeleteShape();
            }

            else if (inuput == 0)
            {
                break;
                var menu = new Main();
                menu.run();
            }
        }
    }
}