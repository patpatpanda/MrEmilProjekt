using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class CreateShape
    {  
        public CreateShape(IShapeFactory shapeFactory, AppDbContext context)
        {
            myContext = context;
            myShapeFactory = shapeFactory;
        }

        public AppDbContext myContext { get; set; }
        public IShapeFactory myShapeFactory { get; set; }

        public void RectangleFormManager()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var bas = ShapeWidthInput();
                    var height = ShapeHeightInput();

                    var shape = myShapeFactory.CreateRectangle(bas, height);

                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    ResultMessageShape(shape);
                    break;
                }
                catch (Exception e)
                {
                    ErrorMessage(e);
                }
            }
            



        }

       
        public void ParaelleogramManager()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var bas = ShapeWidthInput();
                    var height = ShapeHeightInput();

                    var shape = myShapeFactory.CreateParaellogram(bas, height);
                    
                    
                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    ResultMessageShape(shape);
                    break;
                }
                catch (Exception e)
                {
                    ErrorMessage(e);
                }
            }
            
        }

      

        public void TriangelManager()
        {
            while (true)
            {
                try{

                    Console.Clear();
                    var bas = ShapeWidthInput();
                    var height = ShapeHeightInput();
                    Console.Write("Hypotenusa : ");
                    double hypotenusa = Convert.ToDouble(Console.ReadLine());


                    var shape = myShapeFactory.CreateTriangle(bas, height,hypotenusa);

                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    ResultMessageShape(shape);
                    break;

                    

                    
                    
                }
                catch (Exception e)
                {
                   ErrorMessage(e);
                }
            }
            Console.Clear();
            

        }

        public void RombManager()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var bas = ShapeWidthInput();
                    var height = ShapeHeightInput();
                    var shape = myShapeFactory.CreateRomb(bas, height);
                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    ResultMessageShape(shape);
                    break;
                }
                catch (Exception e)
                {
                    ErrorMessage(e);
                }
            }
            
            
        }

        //public void NewShapeManager()
        //{
        //    Console.WriteLine("Name : ");
        //    var name = Console.ReadLine();
        //    Console.Write("Area : ");
        //    var area = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Circumference : ");
        //    var circumference = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Datum (yyyy-mm-dd) : ");
        //    var date = Convert.ToDateTime(Console.ReadLine());



        //    var shape = myShapeFactory.CreateNewShape(name,area,circumference,date);
        //    myContext.Shapes.Add(shape);
        //    myContext.SaveChanges();
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.WriteLine("Succeed!");
        //    Console.WriteLine("Press any key to continue");
        //    Console.ReadKey();
        //}

        private static double ShapeWidthInput()
        {
            Console.Write("Type base : ");
            double bas = Convert.ToDouble(Console.ReadLine());
            return bas;
        }

        private static double ShapeHeightInput()
        {
            Console.Write("Type height : ");
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        private static void ResultMessageShape(Shape shape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {shape.Area}");
            Console.WriteLine($"Omkrets = {shape.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        private static void ErrorMessage(Exception e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
