using MrEmilProjekt.Data;

namespace MrEmilProjekt.Shapes;

public class ShapesMenu
{
    public void ShowShapesMenu()
    {
        while (true)
        {
            try
            {
                var buildApp = new Builder();
                var myContext = buildApp.AppBuilder();
                var factory = new ShapeFactory();
                var createShape = new CreateShape(factory, myContext);
                var readShape = new ShapeController(myContext);


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
                    createShape.RectangleFormManager();
                }


                else if (inuput == 2)
                {
                    createShape.ParaelleogramManager();
                }


                else if (inuput == 3)
                {
                    createShape.TriangelManager();
                }
                else if (inuput == 4)
                {
                    createShape.RombManager();
                }
                else if (inuput == 5)
                {
                    readShape.ListShape();
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                }
                else if (inuput == 6)
                {
                    readShape.UpdateShape();
                }
                else if (inuput == 7)
                {
                    readShape.DeleteShape();
                }
                ////else if (inuput == 8)
                ////{
                ////    createShape.NewShapeManager();
                ////}
                else if (inuput == 0)
                {
                    break;
                    var menu = new Main();
                    menu.run();
                }

            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can only put 0-7 as choice");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }
        }
    }
}