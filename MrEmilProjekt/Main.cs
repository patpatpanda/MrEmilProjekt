using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;

namespace MrEmilProjekt
{
    public class Main
    {
        public void run()
        {

            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();
            var create = new CreateShape(myContext);
            var read = new ShapeController(myContext);
            
            while (true)
            {
                try
                {
                    var input = MainMenu.ShowMenu();
                    if (input == 1)
                    {
                        var test = new ShapesMenu();
                      int shapeInput =  test.ShowShapesMenu();
                      if (shapeInput == 1)
                      {
                          create.RektangelFormManeger();
                      }
                      


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
