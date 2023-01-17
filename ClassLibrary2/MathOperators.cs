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
        
        public class Add : IMathInput
        {
            public decimal Execute(decimal a, decimal b)
            {
                return a + b;
            }
        }

       

       

        public class Subtraction : IMathInput
        {
            public decimal Execute(decimal a, decimal b)
            {
                return a - b;
            }
        }
        public class Divided : IMathInput
        {
            public decimal Execute(decimal a, decimal b)
            {
                return a / b;
            }
        }

        public class Modulo : IMathInput
        {
            public decimal Execute(decimal a, decimal b)
            {
                return a % b;
            }
        }

        public class Multiply : IMathInput
        {
            public decimal Execute(decimal a, decimal b)
            {
                return a * b;
            }
        }

        

    }

    
}
