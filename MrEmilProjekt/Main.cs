using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Controllers;
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

            while (true)
            {
                try
                {
                    var input = MainMenu.ShowMenu();
                    if (input == 1)
                    {
                        var test = new ShapesMenu();
                      int ChoiseOfForm =  test.ShowShapesMenu();
                      if (ChoiseOfForm == 1)
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
