using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MrEmilProjekt.Data
{
    public class Shape
    {
       


            public int ShapeId { get; set; }
            public string Name { get; set; }
            public double Base { get; set; }
            public double Hight { get; set; }

            public double Area { get; set; }
            public double Circumference { get; set; }







        
    }
}
