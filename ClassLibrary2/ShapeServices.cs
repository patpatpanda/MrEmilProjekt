using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace ClassLibrary2
{
    public class ShapeServices : IShape

    {




    public double AreaCalculator(double b, double h)
    {
        var area = b * h;
        return area;

    }

    public double PerimeterCalculator(double b, double h)
    {

        var circumference = b + h + b + h;

        return circumference;
    }

    public double TriangleAreaCalculator(double a, double b)
    {
        return a * b / 2;
    }

    public double TrianglePerimeterCalculator(double a, double b, double c)
    {
        return a + b + c;
    }
    
    }
}
