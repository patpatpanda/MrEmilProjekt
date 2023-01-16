using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class Shape
    {



        public int ShapeId { get; set; }
        public string Name { get; set; }

        public decimal Lenght { get; set; }
        public decimal Height { get; set; }
            
        

        public decimal Area { get; set; }
        public decimal Perimeter { get; set; }

        public DateTime Date { get; set; }



        public void NewShapeValues(string _name,decimal _area, decimal _perimeter, DateTime _date)
        {
            Name = _name;
            
            Area = _area;
            Perimeter = _perimeter;
           Date = _date;
        }

        public void ResultMessage(Shape myShape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {myShape.Area}\nOmkrets = {myShape.Perimeter}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

    }
}
