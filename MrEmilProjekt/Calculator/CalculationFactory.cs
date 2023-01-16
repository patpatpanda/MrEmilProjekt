using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

using MrEmilProjekt.Data;


namespace MrEmilProjekt.Calculator
{
    public class CalculationFactory 
    {


        public CalculationFactory(Calculator _calculator,MathOperators math,AppDbContext context)
        {
            myMath = math;
            calculator = _calculator;
            myContext = context;
         

        }
      
        public AppDbContext myContext { get; set; }
        public MathOperators myMath { get; set; }
        public Calculator calculator { get; set; }
        public void AdditionMaker()
        {
            Console.Clear();
            calculator.FirstInput = NumOne();
            calculator.SecondInput = NumTwo();
            
            Console.Clear();
            calculator.Result = myMath.Addition(calculator.FirstInput, calculator.SecondInput);
            calculator.Operator = "+";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
           

        }



        public void SqrtMaker()
        {
           
            Console.Clear();
            
            Console.Write("Enter a number : ");
            var input = Convert.ToDouble(Console.ReadLine());
            calculator.FirstInput = Convert.ToDecimal(input);
            calculator.Result = Convert.ToDecimal(System.Math.Sqrt(input));
            calculator.Operator = "√";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            
        }

        public void DividedMaker()
        {
           
            Console.Clear();

            calculator.FirstInput = NumOne();
            calculator.SecondInput = NumTwo();
            calculator.Operator = "/";
            calculator.Result = myMath.Divided(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
        }

        public void ModuloMaker()
        {

            Console.Clear();

            calculator.FirstInput = NumOne();
            calculator.SecondInput = NumTwo();
            calculator.Operator = "%";
            calculator.Result = myMath.Modulo(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            
        }

        public void MultiplyMaker()
        {

            Console.Clear();
            calculator.FirstInput = NumOne();
            calculator.SecondInput = NumTwo();

            calculator.Operator = "*";
            calculator.Result = myMath.Multiply(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            
        }

        public void SubtractionMaker()
        {

            Console.Clear();
            calculator.FirstInput = NumOne();
            calculator.SecondInput = NumTwo();

            calculator.Operator = "-";
            calculator.Result = myMath.Subtraction(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();

            
        }
        private static decimal NumTwo()
        {
            decimal numTwo;
            Console.Write("Enter a number : ");

            numTwo = Convert.ToDecimal(Console.ReadLine());
            return numTwo;
        }

        private static decimal NumOne()
        {
            decimal numOne;
            Console.Write("Enter a number : ");
            numOne = Convert.ToDecimal(Console.ReadLine());
            return numOne;
        }
    }
}
