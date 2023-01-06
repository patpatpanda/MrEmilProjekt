using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Controllers;

namespace MrEmilProjekt
{
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
                        ShapesMenu.ShowShapesMenu();
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
