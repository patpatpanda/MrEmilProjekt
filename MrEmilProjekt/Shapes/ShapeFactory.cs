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

        public ShapeFactory(Shape _shape, IShape iShape , AppDbContext context)
        {
          
            myContext = context;
            myShape = _shape;
            myIShape = iShape;
        }

        public AppDbContext myContext { get; set; }
        public Shape myShape;
        public IShape myIShape { get; set; }
       
        public void CreateRectangle()
        {

            
                Console.Clear();
                myShape.Name = "Rectangle";
                myShape.Lenght = GetLenght();
                myShape.Height = GetHeight();
                AreaAndPerimeter();
                SaveShapeToDataBase();



        }

        

        public void CreateParaellogram()
        {
            Console.Clear();
            myShape.Name = "Paraellogram";
            myShape.Lenght = GetLenght();
            myShape.Height = GetHeight();
            AreaAndPerimeter();
            SaveShapeToDataBase();

        }

        public void CreateTriangle()
        {
            Console.Clear();
            myShape.Name = "Triangle";
            myShape.Lenght = GetLenght();
            myShape.Height = GetHeight();
            Console.Write("Enter hypotenusa : ");
            var hypotenusa = Convert.ToDecimal(Console.ReadLine());
            AreaPerimeterTriangle(hypotenusa);
            SaveShapeToDataBase();
        }

        

        private void AreaPerimeterTriangle(decimal hypotenusa)
        {
            myShape.Area = myIShape.TriangleAreaCalculator(myShape.Lenght, myShape.Height);
            myShape.Perimeter = myIShape.TrianglePerimeterCalculator(myShape.Lenght, hypotenusa, myShape.Height);
        }

        public void CreateRomb()
        {
            Console.Clear();
            myShape.Name = "Romb.....";
            myShape.Lenght = GetLenght();
            myShape.Height = GetHeight();
            AreaAndPerimeter();
            SaveShapeToDataBase();

        }


        private static decimal GetLenght()
        {
            while (true)
            {
                try
                {
                    decimal length;
                    Console.Write("Enter length : ");

                    length = Convert.ToDecimal(Console.ReadLine());
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

        private static decimal GetHeight()
        {

            while (true)
            {
                try
                {
                    decimal height;
                    Console.Write("Enter height : ");

                    height = Convert.ToDecimal(Console.ReadLine());
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
            

            myShape.Date = DateTime.Now;
            myShape.ResultMessage(myShape);
            myContext.Shapes.Add(myShape);
            myContext.SaveChanges();
        }

        private void AreaAndPerimeter()
        {
            myShape.Area = myIShape.AreaCalculator(myShape.Lenght, myShape.Height);
            myShape.Perimeter = myIShape.PerimeterCalculator(myShape.Lenght, myShape.Height);
        }
    }

}
