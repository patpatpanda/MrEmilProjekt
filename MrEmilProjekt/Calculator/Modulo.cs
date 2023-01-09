using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    internal class Modulo
    {
        public Modulo(AppDbContext context)
        {
            myContext = context;

        }

        public AppDbContext myContext { get; set; }

        public void ModuloCalculator()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            calculator.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calculator.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calculator.Operator = "%";
            calculator.Result = calculator.FirstInput % calculator.SecondInput;
            calculator.Date = DateTime.Now;
            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();

            calculator.ResultMessage(calculator);
            Console.ReadKey();




        }
    }
}
