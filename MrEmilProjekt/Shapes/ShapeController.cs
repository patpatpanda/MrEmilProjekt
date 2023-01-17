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
        private AppDbContext myContext { get; set; }

        

        public ShapeController(AppDbContext context)
        {
            myContext = context;
        }

        public ShapeController()
        {
        }

        public void ListShape()
        {

            Console.Clear();
            
            Console.WriteLine("****************** All Shapes **********************");
            Console.WriteLine();
           Console.WriteLine("Id\tNamn\t\t\tArea\t\tOmkrets");
            Console.WriteLine("=====================================================");
            foreach (var shape in myContext.Shapes.OrderBy(x => x.ShapeId))
            {
                
                Console.WriteLine($"{shape.ShapeId}\t{shape._Name}\t\t{shape.Area}\t\t{shape.Perimeter}");
               

            }

           

        }

        public void UpdateShape()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    var shapeId = GetShapeId();
                    Console.Clear();
                    Console.Write("Name : ");
                    var name = Console.ReadLine();
                    Console.Write("Height : ");
                    var height = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Lenght : ");
                    var lenght = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Area : ");
                    var area = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Peremiter : ");
                    var Perimeter = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Date (yyyy-mm-dd)");
                    var date = Convert.ToDateTime(Console.ReadLine());
                    shapeId.NewShapeValues(name,lenght,height, area, Perimeter, date);
                    myContext.SaveChanges();

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
        private Shape GetShapeId()
        {
            while (true)
            {
                try
                {
                    ListShape();
                    Console.Write("\nType (Id) for update shape : ");


                    var shapeId = int.Parse(Console.ReadLine());
                    var editShape = myContext.Shapes.First(x => x.ShapeId == shapeId);
                    return editShape;
                }
                catch 
                {
                   NotValidIdMessage();
                }
            }
            
        }

        public void DeleteShape()
        {
            while (true)
            {
                try
                {
                   ListShape();
                    Console.Write("\nType (Id) for update shape : ");
                    var roomId = int.Parse(Console.ReadLine());
                    var delete = myContext.Shapes.First(x => x.ShapeId == roomId);


                    myContext.Shapes.Remove(delete);
                    myContext.SaveChanges();
                    SuccsessMessage();
                    break;
                }
                catch
                {
                    NotValidIdMessage();
                }
            }
        }

        private static void NotValidIdMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNot valid (Id)");
            Console.WriteLine("\nPress any key to continue");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }

        private static void SuccsessMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succeed");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.WriteLine("S");
        }
    }
}
