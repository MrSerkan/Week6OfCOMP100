using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Add the number from 20 to 30 and display the sum
 */

namespace D3_using_accumlator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 20, end = 30, sum = 0;
            do
            {
                sum = sum + start;
                start = start + 1;
            } while (start <= 30);
            Console.WriteLine($" the sum from 20 to {end} is {sum}");

        }
    }
}
