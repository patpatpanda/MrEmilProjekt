using MrEmilProjekt.Data;
using MrEmilProjekt.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    internal class CalculatorController
    {
        private AppDbContext myContext { get; set; }



        public CalculatorController(AppDbContext context)
        {
            myContext = context;
        }
        public void ListCalculator()
        {

            Console.Clear();

            Console.WriteLine("***************** ***********************");
            Console.WriteLine();
            Console.WriteLine("Id\tnumber1\t\tnumber2\t\tOperator\tResultat");
            Console.WriteLine("===========================================================================");
            foreach (var calculator in myContext.Calculators.OrderBy(x => x.Id))
            {

                Console.WriteLine($"{calculator.Id}\t{calculator.FirstInput}\t\t{calculator.SecondInput}\t\t{calculator.Operator}\t\t{calculator.Result}");

            }

            

        }

        public void UpdateCalculator()
        {
            var shapeId = GetShapeId();
            Console.Write("Namn : ");
            var name = Console.ReadLine();
            Console.Write("Area : ");
            var area = Convert.ToDouble(Console.ReadLine());
            Console.Write("Omkrets : ");
            var circumference = Convert.ToDouble(Console.ReadLine());
            var date = Convert.ToDateTime(Console.ReadLine());
            shapeId.NewShapeValues(name, area, circumference, date);
            myContext.SaveChanges();

        }
        private Shape GetShapeId()
        {
            while (true)
            {
                try
                {
                    
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
                    
                    Console.Write("\nType (Id) for update shape : ");
                    var roomId = int.Parse(Console.ReadLine());
                    var delete = myContext.Shapes.First(x => x.ShapeId == roomId);


                    myContext.Shapes.Remove(delete);
                    myContext.SaveChanges();

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

            Console.ReadLine();
        }

    }
}
