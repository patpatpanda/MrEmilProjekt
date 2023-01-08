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
                    shape.Name = "Rektangel";
                    Console.Write("Ange bas : ");
                    double bas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ange Höjd : ");
                    double hight = Convert.ToDouble(Console.ReadLine());
                    shape.Area = bas * hight;
                    shape.Circumference = bas + hight + bas + hight;
                    shape.Date = DateTime.Now;
                    myContext.Shapes.Add(shape);
                    myContext.SaveChanges();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Area = {shape.Area}");
                    Console.WriteLine($"Omkrets = {shape.Circumference}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nTryck valfri tangent för att fortsätta");
                    Console.ReadKey();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    
                }
            }   
          




        }
        public void ParaelleogramManeger()
        {


            




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
           

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {shape.Area}");
            Console.WriteLine($"Omkrets = {shape.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();

            myContext.Shapes.Add(shape);
            myContext.SaveChanges();

        }

        public void RombManeger()
        {
            

        }






    }
}
