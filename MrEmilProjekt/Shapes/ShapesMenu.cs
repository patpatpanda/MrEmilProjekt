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
            var factory = new ShapeFactory();
            var createShape = new CreateShape(factory, myContext);
            var readShape = new ShapeController(myContext);


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("                             ---------------------------------------------------");
            Console.WriteLine("                             |      ****         1:  Rectangle         ****     |");
            Console.WriteLine("                             |      ****         2:  Parallellogram    ****     |");
            Console.WriteLine("                             |      ****         3:  Triangele         ****     |");
            Console.WriteLine("                             |      ****         4:  Romb              ****     |");
            Console.WriteLine("                             |      ****         5:  List              ****     |");
            Console.WriteLine("                             |      ****         6:  Update            ****     |");
            Console.WriteLine("                             |      ****         7:  Delete            ****     |");
            Console.WriteLine("                             |      ****         8:  Create            ****     |");
            Console.WriteLine("                             |      ****         0:  Mainmeny          ****     |");
            Console.WriteLine("                             ----------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("                                                    Choise : ");
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
            else if (inuput == 8)
            {
                createShape.NewShapeManager();
            }
            else if (inuput == 0)
            {
                var menu = new Main();
                menu.run();
            }
        }
    }
}