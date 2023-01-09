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
        

        public Multiply(AppDbContext context)
        {
            myContext = context;

        }

        public AppDbContext myContext { get; set; }

        public void MultiplyCalculator()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            calculator.FirstInput = Convert.ToDecimal(Console.ReadLine());
            calculator.Operator = "";
            calculator.Result = calculator.FirstInput + calculator.SecondInput;
           calculator.Date = DateTime.Now;
            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();

            calculator.ResultMessage(calculator);
            Console.ReadKey();




        }
    }
}
