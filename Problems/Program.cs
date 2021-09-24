using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    
    
    class Program
    {   struct ExpressionBool
        {
            public bool x;
            public bool y;
            public bool z;
            public void task()
            {
                Console.Write($"X = {x}\t");
                Console.Write($"Y = {y}\t");
                Console.WriteLine($"Z = {z}");
                Console.WriteLine($"\nа) не (X или Y) и (не X или не Z) = {!(x || y) && (!x || !z)}");
                Console.WriteLine($"б) не (не X и Y) или (X и не Z) = {!(!x && y) || (x && !z)}");
                Console.WriteLine($"в) X или не Y и не (X или не Z) = {x || !y && !(x || !z)}");

            }
        }
        static void Main(string[] args)
        {
            //do
            //{
            //    int k = 0;
            //    Console.WriteLine(k+"\n");
            //}
            //while (false);
            //int k = 0;
            //Console.WriteLine($"\nа) не (X или Y) и (не X или не Z) = {!(xBool || yBool) && (!xBool || !zBool)}");
            //Console.WriteLine($"\nб) не (не X и Y) или (X и не Z) = {!(!xBool && yBool) || (xBool && !zBool)}");
            //Console.WriteLine($"\nв) X или не Y и не (X или не Z) = {xBool || !yBool && !(xBool || !zBool)}");

            ExpressionBool ex;
            bool x = false;
            bool y = false;
            bool z = false;

            do
            {
                Console.Write($"X = {x}\t");
                Console.Write($"Y = {y}\t");
                Console.WriteLine($"Z = {z}");
                Console.WriteLine($"а) не (X или Y) и (не X или не Z) = {!(x || y) && (!x || !z)}");
                Console.WriteLine($"б) не (не X и Y) или (X и не Z) = {!(!x && y) || (x && !z)}");
                Console.WriteLine($"в) X или не Y и не (X или не Z) = {x || !y && !(x || !z)}\n");
                if (!x)
                {
                    x = true;
                }
                else
                {
                    x = false;
                    if (!y)
                    {
                        y = true;
                    }
                    else
                    {
                        y = false;
                        if (!z)
                        {
                            z = true;
                        }
                        else
                        {
                            z = false;
                        }
                    }
                }

            }
            while (x || z || y);



        }
    }
}
