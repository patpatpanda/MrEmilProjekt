using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
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
            var rektangel = new Shape();
            rektangel.Name = "Rektangel";

            Console.Write("Ange längd : ");

            rektangel.Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange bredd : ");
            rektangel.Hight = Convert.ToDouble(Console.ReadLine());

            rektangel.Area = rektangel.Base * rektangel.Hight;
            var omkrets = rektangel.Base + rektangel.Hight;
            rektangel.Circumference = omkrets * 2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {rektangel.Area}");
            Console.WriteLine($"Omkrets = {rektangel.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTryck valfri tangent för att fortsätta");
            Console.ReadKey();

            myContext.Shapes.Add(rektangel);
            myContext.SaveChanges();






        }

        public void ParallelogramManeger()
        {
            
        }
    }
}
