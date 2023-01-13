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
        public Calculator AdditionMaker()
        {
           
            
            Console.Clear();
            calculator.Result = myMath.Addition(calculator.FirstInput, calculator.SecondInput);
            calculator.Operator = "+";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            return calculator;

        }



        public Calculator SqrtMaker()
        {
           
            Console.Clear();



            calculator.Result = myMath.Sqrt(calculator.FirstInput);
            calculator.Operator = "√";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            return calculator;
        }

        public Calculator DividedMaker()
        {
           
            Console.Clear();
           
           
            calculator.Operator = "/";
            calculator.Result = myMath.Divided(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            return calculator;
        }

        public Calculator ModuloMaker()
        {

            Console.Clear();


            calculator.Operator = "%";
            calculator.Result = myMath.Modulo(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            return calculator;
        }

        public Calculator MultiplyMaker()
        {

            Console.Clear();


            calculator.Operator = "*";
            calculator.Result = myMath.Multiply(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();
            return calculator;
        }

        public Calculator SubtractionMaker()
        {

            Console.Clear();


            calculator.Operator = "-";
            calculator.Result = myMath.Subtraction(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);

            myContext.Calculators.Add(calculator);
            myContext.SaveChanges();

            return calculator;
        }

    }
}
