using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    internal class Sqrt : Calculator
    {
        

        public Sqrt(AppDbContext context)
        {
            myContext = context;

        }

        public AppDbContext myContext { get; set; }

        public void SqrtCalculator()
        {
            

            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            var input = Convert.ToDouble(Console.ReadLine());
            calculator.FirstInput = Convert.ToDecimal(input);
            calculator.Result = Convert.ToDecimal(System.Math.Sqrt(input));
            calculator.Operator = "√";
            calculator.Date = DateTime.Now;
            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            calculator.ResultMessage(calculator);
            Console.ReadKey();




        }
    }
}
