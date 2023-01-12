using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class MathOperators : iMath
    {

        public decimal Addition(decimal numOne, decimal numTwo)
        {
           numOne = NumOne();
            numTwo = NumTwo();
            return numOne + numTwo;

        }
        public decimal Subtraction(decimal numOne, decimal numTwo)
        {
            numOne = NumOne();
            numTwo = NumTwo();
            return numOne - numTwo;

        }
        public decimal Divided(decimal numOne, decimal numTwo)
        {
            numOne = NumOne();
            numTwo = NumTwo();
            return numOne / numTwo;

        }
        public decimal Sqrt(decimal numOne)
        {
            Console.Write("Enter a number : ");
            var numOneAsDouble = Convert.ToDouble(Console.ReadLine());
            numOne = Convert.ToDecimal(numOneAsDouble);
            numOne = Convert.ToDecimal(System.Math.Sqrt(numOneAsDouble));


            return numOne;

        }

        public decimal Modulo(decimal numOne, decimal numTwo)
        {
            numOne = NumOne();
            numTwo = NumTwo();

            return numOne % numTwo;

        }
        public decimal Multiply(decimal numOne, decimal numTwo)
        {
            numOne = NumOne();
            numTwo = NumTwo();
            return numOne % numTwo;

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
