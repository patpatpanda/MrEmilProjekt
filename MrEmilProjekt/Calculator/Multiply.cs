using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
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
           calc.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calc.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calc.Operator = "+";
          calc.Result = calc.FirstInput + calc.SecondInput;
           calc.Date = DateTime.Now;
           myContext.Calculators.Add(calc);
            myContext.SaveChanges();
            Console.WriteLine(calc.Result);
            Console.ReadKey();




        }
    }
}
