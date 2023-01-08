using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    internal class CreateShape
    {  
        public CreateShape()
        {
        }

        public CreateShape(AppDbContext context)
        {
            myContext = context;
        }

        public AppDbContext myContext { get; set; }
        public void RektangelFormManeger()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var shape = new Shape();
                    var bas = ShapeSidesInput(out var hight);

                    shape.Name = "Rektangel";
                    shape.Area = AreaCalculator(bas, hight);
                    shape.Circumference = CircumferenceCalculator(bas, hight);

                    shape.Date = DateTime.Now;
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

       
        public void ParaelleogramManeger()
        {
            Console.Clear();
            var shape = new Shape();
            var bas = ShapeSidesInput(out var hight);
            
            shape.Name = "Paraellegram";
            shape.Area = AreaCalculator(bas,hight);
          shape.Circumference =  CircumferenceCalculator(bas, hight);

            shape.Date = DateTime.Now;
            myContext.Shapes.Add(shape);
            myContext.SaveChanges();

            ResultMessage(shape);
        }

      

        public void TriangelManeger()
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

        }

        public void RombManeger()
        {
            Console.Clear();
            var shape = new Shape();
            var bas = ShapeSidesInput(out var hight);

            shape.Name = "Paraellegram";
            shape.Area = AreaCalculator(bas, hight);
            shape.Circumference = CircumferenceCalculator(bas, hight);

            shape.Date = DateTime.Now;
            myContext.Shapes.Add(shape);
            myContext.SaveChanges();

            ResultMessage(shape);

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
        private static double ShapeSidesInput(out double hight)
        {
            Console.Write("Ange bas : ");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange Höjd : ");
            hight = Convert.ToDouble(Console.ReadLine());
            return bas;
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
