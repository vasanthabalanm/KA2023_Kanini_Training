﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Car:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive class inherited");
        }
    }
}
