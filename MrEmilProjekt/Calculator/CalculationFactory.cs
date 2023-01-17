using ClassLibrary2;
using MrEmilProjekt.Data;

namespace MrEmilProjekt.Calculator;

public class CalculationFactory
{
    public CalculationFactory(MathOperators math, AppDbContext context, Calculator _calculator)
    {
        myMath = math;
        myContext = context;
        calculator = _calculator;
    }

    public AppDbContext myContext { get; set; }
    public MathOperators myMath { get; set; }
    public Calculator calculator { get; set; }

    public void AdditionMaker()
    {
        Console.Clear();
        myContext.SetStrategy(new MathOperators.Add());
        calculator.FirstInput = NumberInputOne();
        calculator.SecondInput = NumberInputTwo();
        calculator.Operator = "+";

        SaveCalcToDataBase();
    }


    public void SqrtMaker()
    {
        Console.Clear();

        NumberInputOne();
        var input = Convert.ToDouble(Console.ReadLine());
        calculator.FirstInput = Convert.ToDecimal(input);
        calculator.Result = Convert.ToDecimal(Math.Sqrt(input));
        calculator.Operator = "√";
        calculator.Date = DateTime.Now;
        calculator.ResultMessage(calculator);
        myContext.Calculators.Add(calculator);
        myContext.SaveChanges();
    }

    public void DividedMaker()
    {
        Console.Clear();
        myContext.SetStrategy(new MathOperators.Divided());
        calculator.FirstInput = NumberInputOne();
        calculator.SecondInput = NumberInputTwo();
        calculator.Operator = "/";
        SaveCalcToDataBase();
    }

    public void ModuloMaker()
    {
        Console.Clear();
        myContext.SetStrategy(new MathOperators.Modulo());
        calculator.FirstInput = NumberInputOne();
        calculator.SecondInput = NumberInputTwo();
        calculator.Operator = "%";
        SaveCalcToDataBase();
    }

    public void MultiplyMaker()
    {
        Console.Clear();
        myContext.SetStrategy(new MathOperators.Multiply());
        calculator.FirstInput = NumberInputOne();
        calculator.SecondInput = NumberInputTwo();
        calculator.Operator = "*";
        SaveCalcToDataBase();
    }

    public void SubtractionMaker()
    {
        Console.Clear();
        myContext.SetStrategy(new MathOperators.Subtraction());
        calculator.FirstInput = NumberInputOne();
        calculator.SecondInput = NumberInputTwo();
        calculator.Operator = "-";
        SaveCalcToDataBase();
    }

    private void SaveCalcToDataBase()
    {
        calculator.Result = myContext.ExecuteStrategy(calculator.FirstInput, calculator.SecondInput);

        calculator.Date = DateTime.Now;
        calculator.ResultMessage(calculator);

        myContext.Calculators.Add(calculator);
        myContext.SaveChanges();
    }

    private static decimal NumberInputOne()
    {
        while (true)
            try
            {
                decimal numTwo;
                Console.Write("Enter first number : ");

                numTwo = Convert.ToDecimal(Console.ReadLine());
                return numTwo;
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

    private static decimal NumberInputTwo()
    {
        while (true)
            try
            {
                decimal numTwo;
                Console.Write("Enter second number : ");

                numTwo = Convert.ToDecimal(Console.ReadLine());
                return numTwo;
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