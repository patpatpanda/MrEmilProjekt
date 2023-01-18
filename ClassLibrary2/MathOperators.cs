using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;


namespace ClassLibrary2
{
    public class MathOperators 

    {
        
        public class Add : IMath
        {
            public decimal Perform(decimal a, decimal b)
            {
                return a + b;
            }
        }

       

       

        public class Subtraction : IMath
        {
            public decimal Perform(decimal a, decimal b)
            {
                return a - b;
            }
        }
        public class Divided : IMath
        {
            public decimal Perform(decimal a, decimal b)
            {
                return a / b;
            }
        }

        public class Modulo : IMath
        {
            public decimal Perform(decimal a, decimal b)
            {
                return a % b;
            }
        }

        public class Multiply : IMath
        {
            public decimal Perform(decimal a, decimal b)
            {
                return a * b;
            }
        }

        

    }

    
}
