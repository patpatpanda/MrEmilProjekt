using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    public class Calculator
    {
        public int Id { get; set; }
        public decimal FirstInput { get; set; }
        public decimal SecondInput { get; set; }
        public string Operator { get; set; }
        public decimal Result { get; set; }
        public DateTime Date { get; set; }


        public void ResultMessage(Calculator calc)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Resultat = {calc.Result} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();
        }
        
    }
}
