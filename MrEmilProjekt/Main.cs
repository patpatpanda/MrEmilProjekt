using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;

namespace MrEmilProjekt;

public class Main
{
    public void run()
    {
        var buildApp = new Builder();
        var myContext = buildApp.AppBuilder();
        var createShape = new CreateShape(myContext);
        var readShape = new ShapeController(myContext);

        while (true)
            try
            {
                var input = MainMenu.ShowMenu();
                if (input == 1)
                {
                    var test = new ShapesMenu();
                    var shapeInput = test.ShowShapesMenu();
                    if (shapeInput == 1) createShape.RektangelFormManeger();


                    else if (shapeInput == 2) createShape.ParaelleogramManeger();


                    else if (shapeInput == 3) createShape.TriangelManeger();
                    else if (shapeInput == 4) createShape.RombManeger();
                   // else if(shapeInput == 5) readShape.ListShape();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
    }
}