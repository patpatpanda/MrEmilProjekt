﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Shapes
{
    public class Shape
    {



        public int ShapeId { get; set; }
        private string Name { get; set; }

        private double Lenght { get; set; }
        private double Height { get; set; }
            
        

        public double Area { get; set; }
        public double Perimeter { get; set; }

        public DateTime Date { get; set; }

        public string _Name
        {
            get => Name;
            set => Name = value;


        }

        public double _Lenght
        {
            get => Lenght;
            set => Lenght = value;
        }
        public double _Height
        {
            get => Height;
            set => Height = value;
        }

        public void NewShapeValues(string _name,double _lenght,double _height,double _area, double _perimeter, DateTime _date)
        {
            Name = _name;
            Height = _height;
            Lenght = _lenght;
            Area = _area;
            Perimeter = _perimeter;
           Date = _date;
        }

        public void ResultMessage(Shape myShape)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {myShape.Area}\nOmkrets = {myShape.Perimeter}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

    }
}
