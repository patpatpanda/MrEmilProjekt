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




    public decimal AreaCalculator(decimal b, decimal h)
    {
        var area = b * h;
        return area;

    }

    public decimal PerimeterCalculator(decimal b, decimal h)
    {

        var circumference = b + h + b + h;

        return circumference;
    }

    public decimal TriangleAreaCalculator(decimal a, decimal b)
    {
        return a * b / 2;
    }

    public decimal TrianglePerimeterCalculator(decimal a, decimal b, decimal c)
    {
        return a + b + c;
    }
    //
    }
}
