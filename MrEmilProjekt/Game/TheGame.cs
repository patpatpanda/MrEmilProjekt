﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Game
{
    public class TheGame
    {
        public int Id { get; set; }
        public int Win { get; set; }
        public int Lost { get; set; }
        public int Average { get; set; }
        public DateTime Date { get; set; }
    }
}