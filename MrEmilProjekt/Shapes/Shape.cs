using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class Shape
    {



        public int ShapeId { get; set; }
        public string Name { get; set; }


        public double Area { get; set; }
        public double Circumference { get; set; }

        public DateTime Date { get; set; }



        public void NewShapeValues(string _name,double _area,double _circumference,DateTime _date)
        {
            Name = _name;
            
            Area = _area;
            Circumference = _circumference;
            Date = _date;
        }



    }
}
