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

        public void RektangelFormManager()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var bas = ShapeWidthInput();
                    var height = ShapeHeightInput();

                    var shape = myShapeFactory.CreateRectangel(bas, height);

                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    ResultMessage(shape);
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

                    ResultMessage(shape);
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
                try
                {
                    Console.Clear();
                    var shape = new Shape();

                    shape.Name = "Triangel";


                    Console.Write("Ange längd : ");
                    double bas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ange Höjd : ");
                    double hight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ange Hypotenusa: ");
                    double hypotenusa = Convert.ToDouble(Console.ReadLine());

                    shape.Area = bas * hight / 2;
                    shape.Circumference = bas + hypotenusa + hight;
                    shape.Date = DateTime.Now;

                    ResultMessage(shape);

                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();
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

                    ResultMessage(shape);
                    break;
                }
                catch (Exception e)
                {
                    ErrorMessage(e);
                }
            }
            

        }

        private static double ShapeWidthInput()
        {
            Console.Write("Ange bas : ");
            double bas = Convert.ToDouble(Console.ReadLine());
            return bas;
        }

        private static double ShapeHeightInput()
        {
            Console.Write("Ange Höjd : ");
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        private static void ResultMessage(Shape shape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {shape.Area}");
            Console.WriteLine($"Omkrets = {shape.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();
        }
        private static void ErrorMessage(Exception e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.WriteLine("\nTryck valfri tangent för fortsätta");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
