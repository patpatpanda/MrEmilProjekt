﻿using Microsoft.EntityFrameworkCore;
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
            
            Console.WriteLine("****************** All Shapes **********************");
            Console.WriteLine();
           Console.WriteLine("Id\tNamn\t\t\tArea\t\tOmkrets");
            Console.WriteLine("===========================================================================");
            foreach (var shape in myContext.Shapes.OrderBy(x => x.ShapeId))
            {
                
                Console.WriteLine($"{shape.ShapeId}\t{shape.Name}\t\t{shape.Area}\t\t{shape.Circumference}");

            }

           

        }

        public void UpdateShape()
        {
            var shapeId = GetShapeId();
            Console.Write("Namn : ");
            var name = Console.ReadLine();
            Console.Write("Area : ");
            var area = Convert.ToDouble(Console.ReadLine());
            Console.Write("Omkrets : ");
            var circumference = Convert.ToDouble(Console.ReadLine());
            shapeId.NewShapeName(name,area,circumference);
            myContext.SaveChanges();

        }
        private Shape GetShapeId()
        {
            while (true)
            {
                try
                {
                    ListShape();
                    Console.Write("\nAnge (Id) för Shape du vill uppdatera : ");


                    var shapeId = int.Parse(Console.ReadLine());
                    var editShape = myContext.Shapes.First(x => x.ShapeId == shapeId);
                    return editShape;
                }
                catch 
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu kan endast ange ett befintligt (Id)");
                    Console.WriteLine("\nTryck valfri tangent för att fortsätta");

                    Console.ReadLine();
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
                    Console.Write("\nAnge (Id) för Shape du vill radera: ");
                    var roomId = int.Parse(Console.ReadLine());
                    var delete = myContext.Shapes.First(x => x.ShapeId == roomId);


                    myContext.Shapes.Remove(delete);
                    myContext.SaveChanges();
                    
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu kan endast ange ett befintligt (Id)");
                    Console.WriteLine("\nTryck valfri tangent för att fortsätta");

                    Console.ReadLine();
                }
            }
        }

      
    }
}
