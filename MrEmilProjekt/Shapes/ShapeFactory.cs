using ClassLibrary2;
using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Migrations;
using Services;


namespace MrEmilProjekt.Shapes
{
   public class ShapeFactory 
    {
      
        public ShapeFactory(){}

        public ShapeFactory(Shape shape, IShape iShape , AppDbContext context)
        {
          
            myContext = context;
            myShape = shape;
            myIShape = iShape;
        }

        public AppDbContext myContext { get; set; }
        public Shape myShape;
        public IShape myIShape { get; set; }
       
        public void CreateRectangle()
        {

            
                Console.Clear();
                myShape._Name = "Rectangle";
                myShape._Lenght = GetLenght();
                myShape._Height = GetHeight();
                AreaAndPerimeter();
                ResultAndDate();
                SaveShapeToDataBase();



        }

        

        public void CreateParallelogram()
        {
            Console.Clear();
            myShape._Name = "Parallelogram ";
            myShape._Lenght = GetLenght();
            myShape._Height = GetHeight();
            AreaAndPerimeter();
            ResultAndDate();
            SaveShapeToDataBase();

        }

        public void CreateTriangle()
        {
            Console.Clear();
            myShape._Name = "Triangle";
            myShape._Lenght = GetLenght();
            myShape._Height = GetHeight();
            Console.Write("Enter hypotenusa : ");
            var hypotenusa = Convert.ToDouble(Console.ReadLine());
            AreaPerimeterTriangle(hypotenusa);
            SaveShapeToDataBase();
            ResultAndDate();
        }

        

        private void AreaPerimeterTriangle(double hypotenusa)
        {
            myShape.Area = myIShape.TriangleAreaCalculator(myShape._Lenght, myShape._Height);
            myShape.Perimeter = myIShape.TrianglePerimeterCalculator(myShape._Lenght, hypotenusa, myShape._Height);
        }

        public void CreateRhombus()
        {
            Console.Clear();
            myShape._Name = "Rhombus";
            myShape._Lenght = GetLenght();
            myShape._Height = GetHeight();
            AreaAndPerimeter();
            ResultAndDate();
            SaveShapeToDataBase();

        }


        private static double GetLenght()
        {
            while (true)
            {
                try
                {
                    double length;
                    Console.Write("Enter length : ");

                    length = Convert.ToDouble(Console.ReadLine());
                    return length;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadKey();

                }
            }
           
            
        }

        private static double GetHeight()
        {

            while (true)
            {
                try
                {
                   double height;
                    Console.Write("Enter height : ");

                    height = Convert.ToDouble(Console.ReadLine());
                    return height;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadKey();

                }
            }
        }

        private void SaveShapeToDataBase()
        {
            

            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();
        }

        private void ResultAndDate()
        {
            myShape.Date = DateTime.Now;
            myShape.ResultMessage(myShape);
        }

        private void AreaAndPerimeter()
        {
            myShape.Area = myIShape.AreaCalculator(myShape._Lenght, myShape._Height);
            myShape.Perimeter = myIShape.PerimeterCalculator(myShape._Lenght, myShape._Height);
        }
    }

}
