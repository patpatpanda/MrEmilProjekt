using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    internal class ShapeFactory: IShapeFactory
    {
      
        public ShapeFactory(){}

        public Shape CreateRectangle(double bas, double height)
        {
            return CreateTwoSidedShape(bas, height, "Rektangel");
        }

        public Shape CreateRomb(double bas, double height)
        {
            return CreateTwoSidedShape(bas, height, "Romb.....");
        }

        public Shape CreateParaellogram(double bas, double height)
        {
            return CreateTwoSidedShape(bas, height, "Paraellogram");
        }
        public Shape CreateTriangle(double bas, double height, double hypotenusa)
        {
            return CreateThreeSidedShape(bas, height,"Triangel",hypotenusa);
        }
       
        
        private Shape CreateTwoSidedShape(double bas, double height, string name)
        {
            Shape newShape = new Shape();
            newShape.Name = name;
            newShape.Area = AreaCalculator(bas, height);
            newShape.Circumference = CircumferenceCalculator(bas, height);
            newShape.Date = DateTime.Now;
            return newShape;
        }
        private Shape CreateThreeSidedShape(double bas, double height, string name,double hypotenusa)
        {
            Shape newShape = new Shape();
            newShape.Name = name;
            newShape.Area = AreaCalculatorTriangel(bas, height);
            newShape.Circumference = CircumferenceCalculatorTriangel(bas, height,hypotenusa);
            newShape.Date = DateTime.Now;
            return newShape;
        }
    
        private static double AreaCalculator(double b, double h)
        {
            var area = b * h;
            return area;

        }

        private static double CircumferenceCalculator(double b,double h)
        {

            var circumference = b + h + b + h; 
           
            return circumference;
        }

        private static double AreaCalculatorTriangel(double bas, double height)
        {
            var area = bas * height / 2;
            return area;
        }

        private static double CircumferenceCalculatorTriangel(double bas, double hypotenusa,double height)
        {

            var circumference = bas + hypotenusa + height;

            return circumference;
        }

        public Shape CreateNewShape(string name, double area, double circumference, DateTime date)
        {
            var newShape = new Shape();
            newShape.Name = name;
            newShape.Area = area;
            newShape.Circumference = circumference;
            newShape.Date = DateTime.Now;
            return newShape;
        }
    }
}
