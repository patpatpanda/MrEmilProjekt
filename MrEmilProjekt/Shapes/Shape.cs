using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class Shape
    {



        public int ShapeId { get; set; }
        public string Name { get; set; }

        public decimal Bas { get; set; }
        public decimal Height { get; set; }
            
        

        public decimal Area { get; set; }
        public decimal Circumference { get; set; }

        public DateTime Date { get; set; }



        public void NewShapeValues(string _name,decimal _area,decimal _circumference,DateTime _date)
        {
            Name = _name;
            
            Area = _area;
            Circumference = _circumference;
            Date = _date;
        }

        public void ResultMessage(Shape myShape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {myShape.Area}\nOmkrets = {myShape.Circumference}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

    }
}
