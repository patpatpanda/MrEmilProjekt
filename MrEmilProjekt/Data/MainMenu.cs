using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Data
{
    public class MainMenu
    {
        public static int ShowMenu()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("                             ---------------------------------------------------");
                Console.WriteLine("                             |      ****         1:  Shapes               ****  |");
                Console.WriteLine("                             |      ****         2:  Calculator           ****  |");
                Console.WriteLine("                             |      ****         3:  Rock,Paper,Scissors  ****  |");
                Console.WriteLine("                             ----------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("                                                    Choise : ");
                Console.ResetColor();
                var inuput = int.Parse(Console.ReadLine());

                return inuput;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

           
        }
    }
}
