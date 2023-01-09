using MrEmilProjekt.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Data;

namespace MrEmilProjekt.Calculator.NewFolder.NewFolder
{
    public class CalculatorMenu
    {

        public void ShowCalculatorMenu()
        {
            while (true)
            {

                var buildApp = new Builder();
                var myContext = buildApp.AppBuilder();
               



                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("                             -------------------------------------------");
                Console.WriteLine("                             |      ****         1:    +       ****     |");
                Console.WriteLine("                             |      ****         2:    -       ****     |");
                Console.WriteLine("                             |      ****         3:    *       ****     |");
                Console.WriteLine("                             |      ****         4:    /      ****      |");
                Console.WriteLine("                             |      ****         5:    √      ****      |");
                Console.WriteLine("                             |      ****         6:    %      ****      |");
                Console.WriteLine("                             |      ****         7:            ****     |");
                Console.WriteLine("                             |      ****         0:  Huvudmeny ****     |");
                Console.WriteLine("                             --------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("                                                    Val : ");
                Console.ResetColor();
                var inuput = int.Parse(Console.ReadLine());

                if (inuput == 1)
                {

                    var add = new Multiply();
                    add.MultuplyCalculator();
                }


               
            }








        }


    }
}
