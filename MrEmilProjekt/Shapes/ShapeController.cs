using Microsoft.EntityFrameworkCore;
using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class ShapeController
    {
        private AppDbContext myContext;

        public ShapeController()
        {
        }

        public ShapeController(AppDbContext context)
        {
            myContext = context;
        }
        public void ListShape()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************** All Shapes **********************");
            Console.WriteLine();
            Console.WriteLine("Id\tNamn\t\tBas\t\tHöjd\t\tArea\t\tOmkrets");
            Console.WriteLine("======================================================================================================");
            foreach (var shape in myContext.Shapes.OrderBy(x => x.ShapeId))
            {

                Console.WriteLine($"{shape.ShapeId}\t{shape.Name}\t{shape.Base}\t\t{shape.Hight}\t\t{shape.Area}\t\t{shape.Circumference}");

            }

            Console.ReadKey();

        }

        public void UpdateShape()
        {
            var shapeId = GetShapeId();
            Console.Write("Namn : ");
            var name = Console.ReadLine();
            Console.Write("Bas : ");
            var bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Höjd : ");
            var height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Area : ");
            var area = Convert.ToDouble(Console.ReadLine());
            Console.Write("Omkrets : ");
            var circumference = Convert.ToDouble(Console.ReadLine());
            shapeId.NewShapeName(name,bas,height,area,circumference);

        }
        private Shape GetShapeId()
        {
            
            ListShape();
            Console.Write("\nAnge (Id) för Shape du vill uppdatera : ");


            var guestId = int.Parse(Console.ReadLine());
            var editGuest = myContext.Shapes.First(x => x.ShapeId == guestId);
            return editGuest;
        }

        public void DeleteShape()
        {
            while (true)
            {
                try
                {
                   ListShape();
                    Console.Write("\nAnge (Id) för Shape du vill radera: ");
                    var roomId = int.Parse(Console.ReadLine());
                    var delete = myContext.Shapes.First(x => x.ShapeId == roomId);


                    myContext.Shapes.Remove(delete);
                    myContext.SaveChanges();
                    
                    break;
                }
                catch
                {
                    
                }
            }
        }
    }
}
