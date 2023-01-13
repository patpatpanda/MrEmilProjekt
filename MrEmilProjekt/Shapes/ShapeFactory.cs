using ClassLibrary2;
using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MrEmilProjekt.Shapes
{
    internal class ShapeFactory
    {
      
        public ShapeFactory(){}

        public ShapeFactory(Shape _shape, ShapeServices _shapeServices, AppDbContext context)
        {
           myShapeServices = _shapeServices;
            myContext = context;
            myShape = _shape;
        }

        public AppDbContext myContext { get; set; }
        public Shape myShape;
        public ShapeServices myShapeServices { get; set; }

       
        public void CreateRectangle()
        {
            Console.Clear();
            myShape.Name = "Rectangle";
            myShape.Bas = GetBas();
            myShape.Height = GetHeight();
            myShape.Area = myShapeServices.AreaCalculator(myShape.Bas, myShape.Height);
            myShape.Circumference = myShapeServices.CircumferenceCalculator(myShape.Bas, myShape.Height);
            
            myShape.Date = DateTime.Now;
           myShape.ResultMessage(myShape);
            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();
            
        }

        public void CreateParaellogram()
        {
            Console.Clear();
            myShape.Name = "Paraellogram";
            myShape.Bas = GetBas();
            myShape.Height = GetHeight();
            myShape.Area = myShapeServices.AreaCalculator(myShape.Bas, myShape.Height);
            myShape.Circumference = myShapeServices.CircumferenceCalculator(myShape.Bas, myShape.Height);

            myShape.Date = DateTime.Now;
            myShape.ResultMessage(myShape);
            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();

        }

        public void CreateTriangle()
        {
            Console.Clear();
            myShape.Name = "Triangle";
            myShape.Bas = GetBas();
            myShape.Height = GetHeight();
            Console.Write("Enter hypotenusa : ");
            var hypotenusa = Convert.ToDecimal(Console.ReadLine());
            myShape.Area = myShapeServices.TriangleAreaCalculator(myShape.Bas, myShape.Height);
            myShape.Circumference = myShapeServices.TriangelCircumferenceCalculator(myShape.Bas, hypotenusa, myShape.Height);
           

            myShape.Date = DateTime.Now;
            myShape.ResultMessage(myShape);
            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();

        }

        public void CreateRomb()
        {
            Console.Clear();
            myShape.Name = "Romb.....";
            myShape.Bas = GetBas();
            myShape.Height = GetHeight();
            myShape.Area = myShapeServices.AreaCalculator(myShape.Bas, myShape.Height);
            myShape.Circumference = myShapeServices.CircumferenceCalculator(myShape.Bas, myShape.Height);

            myShape.Date = DateTime.Now;
            myShape.ResultMessage(myShape);
            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();

        }

        private static decimal GetBas()
        {
            decimal numTwo;
            Console.Write("Enter base : ");

            numTwo = Convert.ToDecimal(Console.ReadLine());
            return numTwo;
        }

        private static decimal GetHeight()
        {
            decimal numOne;
            Console.Write("Enter height : ");
            numOne = Convert.ToDecimal(Console.ReadLine());
            return numOne;
        }
    }
}
