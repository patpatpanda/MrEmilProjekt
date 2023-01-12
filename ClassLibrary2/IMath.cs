using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public interface iMath
    {
        public decimal Addition(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;

        }
        public decimal Subtraction(decimal numOne, decimal numTwo)
        {
            
            return numOne - numTwo;

        }
        public decimal Divided(decimal numOne, decimal numTwo)
        {
            
            return numOne / numTwo;

        }
        public decimal Sqrt(decimal numOne)
        {


            
            return numOne;

        }

        public decimal Modulo(decimal numOne, decimal numTwo)
        {
           
            return numOne % numTwo;

        }
        public decimal Multiply(decimal numOne, decimal numTwo)
        {
           
            return numOne % numTwo;

        }
    }
}
