﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a = 6.99999;
            Console.WriteLine((int)a);


            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(a);
        }
    }
}
