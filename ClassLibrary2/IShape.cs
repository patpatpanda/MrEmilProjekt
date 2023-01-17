using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IShape
    {
        public double AreaCalculator(double b, double h);


        public double PerimeterCalculator(double b, double h);





        public double TriangleAreaCalculator(double b, double h);


        public double TrianglePerimeterCalculator(double b, double h,double l);



    }
}
