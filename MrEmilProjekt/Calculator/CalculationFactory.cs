using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace MrEmilProjekt.Calculator
{
    public class CalculationFactory : ICalculation
    {


        public CalculationFactory(Calculator _calculator,MathOperators math)
        {
            myMath = math;
            calculator = _calculator;
        }

        public MathOperators myMath { get; set; }
        public Calculator calculator { get; set; }
        public Calculator AdditionMaker()
        {
           
            
            Console.Clear();
            calculator.Result = myMath.Addition(calculator.FirstInput, calculator.SecondInput);
            calculator.Operator = "+";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;

        }



        public Calculator SqrtMaker()
        {
           
            Console.Clear();



            calculator.Result = myMath.Sqrt(calculator.FirstInput);
            calculator.Operator = "√";
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator DividedMaker()
        {
           
            Console.Clear();
           
           
            calculator.Operator = "/";
            calculator.Result = myMath.Divided(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator ModuloMaker()
        {

            Console.Clear();


            calculator.Operator = "%";
            calculator.Result = myMath.Modulo(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator MultiplyMaker()
        {

            Console.Clear();


            calculator.Operator = "*";
            calculator.Result = myMath.Multiply(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

        public Calculator SubtractionMaker()
        {

            Console.Clear();


            calculator.Operator = "-";
            calculator.Result = myMath.Subtraction(calculator.FirstInput, calculator.SecondInput);
            calculator.Date = DateTime.Now;
            calculator.ResultMessage(calculator);
            return calculator;
        }

    }
}
