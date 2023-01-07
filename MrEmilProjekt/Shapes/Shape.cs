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
        public double Base { get; set; }
        public double Hight { get; set; }

        public double Area { get; set; }
        public double Circumference { get; set; }

        public DateTime Date { get; set; }



        public void NewShapeName(string _name,double _base,double _hight,double _area,double _circumference)
        {
            Name = _name;
            Base = _base;
            Hight = _hight;
            Area = _area;
            Circumference = _circumference;
        }



    }
}
