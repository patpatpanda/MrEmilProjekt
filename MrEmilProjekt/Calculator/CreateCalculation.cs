using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace MrEmilProjekt.Calculator
{
    public class CreateCalculation
    {

        public CreateCalculation(ICalculation calculationFactory, AppDbContext myContext)
        {
            this.myContext = myContext;
            MyCalculation = calculationFactory;
           
        }

       
        public AppDbContext myContext { get; set; }
        public ICalculation MyCalculation { get; set; }


        public void AdditionCalculator()
        {
           
            var calculation = MyCalculation.AdditionMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();
            


        }

        public void SqrtCalculator()
        {
            var calculation = MyCalculation.SqrtMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();
        }

        public void DividedCalculator()
        {
            var calculation = MyCalculation.DividedMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();
        }

        public void ModuloCalculator()
        {
            var calculation = MyCalculation.ModuloMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();

        }
        public void MultiplyCalculator()
        {
            var calculation = MyCalculation.MultiplyMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();

        }

        public void SubtractionCalculator()
        {
            var calculation = MyCalculation.SubtractionMaker();
            myContext.Calculators.Add(calculation);
            myContext.SaveChanges();
        }

    }
}
