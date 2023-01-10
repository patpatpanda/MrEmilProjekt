using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    public class CalculationFactory : ICalculation
    {
        public Calculator AdditonMaker()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            calculator.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calculator.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calculator.Operator = "+";
            calculator.Result = calculator.FirstInput + calculator.SecondInput;
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;

        }

        public Calculator SqrtMaker()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            var input = Convert.ToDouble(Console.ReadLine());
            calculator.FirstInput = Convert.ToDecimal(input);
            calculator.Result = Convert.ToDecimal(System.Math.Sqrt(input));
            calculator.Operator = "√";
            calculator.Date = DateTime.Now;
            return calculator;
        }

        public Calculator DividedMaker()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            calculator.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calculator.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calculator.Operator = "/";
            calculator.Result = calculator.FirstInput / calculator.SecondInput;
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator ModuloMaker()
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
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator MultiplyMaker()
        {
            var calculator = new Calculator();
            Console.Clear();
            Console.Write("Mata in ett tal : ");
            calculator.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calculator.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calculator.Operator = "*";
            calculator.Result = calculator.FirstInput * calculator.SecondInput;
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator SubtractionMaker()
        {
            var calc = new Calculator();
            Console.Clear();

            Console.Write("Mata in ett tal : ");
            calc.FirstInput = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mata in ett tal : ");
            calc.SecondInput = Convert.ToDecimal(Console.ReadLine());
            calc.Operator = "-";
            calc.Result = calc.FirstInput - calc.SecondInput;
            calc.Date = DateTime.Now;
           
            calc.ResultMessage(calc);
            return calc;

        }

    }
}
