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
            var calculatorId = GetCalculatorId();
            Console.Write("First number : ");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Second number : ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Operator : ");
            string operatorChoise = Console.ReadLine();
            Console.Write("Result : ");
            decimal result = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Datum (yyyy-mm-dd)");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            calculatorId.NewCalculatorValues(firstNumber,secondNumber,operatorChoise,result,date);

            myContext.SaveChanges();

          SuccsessMessage();


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

        public void DeleteCalculation()
        {
            while (true)
            {
                try
                {
                   var delete = GetCalculatorId();
                    


                    myContext.Calculators.Remove(delete);
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

            Console.ReadLine();
        }
        private Calculator GetCalculatorId()
        {
            while (true)
            {
                try
                {
                    ListCalculator();
                    Console.Write("\nType (Id) : ");


                    var calculatorId = int.Parse(Console.ReadLine());
                    var editCalculator = myContext.Calculators.First(x => x.Id == calculatorId);
                    return editCalculator;
                }
                catch
                {
                    NotValidIdMessage();
                }
            }
           
        }
        private static void SuccsessMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succeed ! ");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.WriteLine("S");
        }
    }
}
