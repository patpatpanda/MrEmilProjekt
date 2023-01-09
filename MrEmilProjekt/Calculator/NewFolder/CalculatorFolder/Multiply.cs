using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator.NewFolder.NewFolder
{
    public class Multiply : Calculator
    {
        public Multiply()
        {
        }

        public Multiply(AppDbContext context)
        {
            myContext = context;
            
        }

        public AppDbContext myContext { get; set; }

        public void MultuplyCalculator()
        {
            var calc = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            SecondInput = Convert.ToDecimal(Console.ReadLine());
            Operator = "+";
            Result = FirstInput + SecondInput;

            myContext.Calculators.Add(calc);
            myContext.SaveChanges();
            Console.WriteLine(Result);
            

            Console.ReadKey();




        }
    }
}
