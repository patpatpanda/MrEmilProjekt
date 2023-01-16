using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IShape
    {
        public decimal AreaCalculator(decimal b, decimal h);


        public decimal PerimeterCalculator(decimal b, decimal h);





        public decimal TriangleAreaCalculator(decimal a, decimal b);


        public decimal TrianglePerimeterCalculator(decimal a, decimal b, decimal c);

        
    }
}
