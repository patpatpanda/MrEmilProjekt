using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Calculator
{
    public interface ICalculation
    {
        Calculator AdditonMaker();
        Calculator SqrtMaker();
        Calculator DividedMaker();
        Calculator ModuloMaker();
        Calculator MultiplyMaker();
        Calculator SubtractionMaker();
    }
}
