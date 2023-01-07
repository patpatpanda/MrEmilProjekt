﻿using MrEmilProjekt.Data;
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

            Console.Clear();
            var triangel = new Triangel();
            



            Console.Write("Ange längd : ");

            triangel.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange bredd : ");
            triangel.Hight = Convert.ToDouble(Console.ReadLine());

            triangel.Area = triangel.Base * triangel.Hight;
            var omkrets = triangel.Base + triangel.Hight;
            triangel.Circumference = omkrets * 2;
            triangel.Date = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {triangel.Area}");
            Console.WriteLine($"Omkrets = {triangel.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();

            myContext.Triangels.Add(triangel);
            myContext.SaveChanges();






        }
        public void ParaelleogramManeger()
        {



            Console.Clear();
            var shape = new Shape();
            shape.Name = "Paraellogram";



            Console.Write("Ange längd : ");

            shape.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange bredd : ");
            shape.Hight = Convert.ToDouble(Console.ReadLine());

            shape.Area = shape.Base * shape.Hight;
            var omkrets = shape.Base + shape.Hight;
            shape.Circumference = omkrets * 2;
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

        public void TriangelManeger()
        {
            Console.Clear();
            var triangel = new Triangel();




            Console.Write("Ange längd : ");

            triangel.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange bredd : ");
            triangel.Hight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange Hypotenusa : ");
            triangel.Hypotenusa = Convert.ToDouble(Console.ReadLine());

            triangel.Area = triangel.Base * triangel.Hight / 2;

            triangel.Circumference = triangel.Base + triangel.Hight + triangel.Hypotenusa;
            triangel.Date = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {triangel.Area}");
            Console.WriteLine($"Omkrets = {triangel.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();

            myContext.Triangels.Add(triangel);
            myContext.SaveChanges();

        }

        public void RombManeger()
        {
            Console.Clear();
            var shape = new Shape();
            shape.Name = "Romb.....";



            Console.Write("Ange längd : ");

            shape.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange bredd : ");
            shape.Hight = Convert.ToDouble(Console.ReadLine());

            shape.Area = shape.Base * shape.Hight;
            var omkrets = shape.Base + shape.Hight;
            shape.Circumference = omkrets * 2;
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






    }
}
