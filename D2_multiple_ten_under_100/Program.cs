using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Print all the multiples of 10 less than 100 in decending order.
 */

namespace D2_multiple_ten_under_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initializer
            int start = 100, stop = 0, multiple = 10;
            do
            {
                //code statements
                if (start % multiple == 0)
                {
                    Console.WriteLine(start);
                }
                //updater
                start = start - 1;
            } while (start >= stop); //checker
        }
    }
}
