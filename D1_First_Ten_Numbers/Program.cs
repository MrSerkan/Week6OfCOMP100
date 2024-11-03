using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a Program that dispauy the first 10 natural numbers inascenting order using a do-while loop.
 */

namespace D1_First_Ten_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialisers
            int start = 1, end = 10;

            do
            {
                //code statements
                Console.WriteLine($"{start}");
                //updaters
                start = start + 1;
            } while (start <= end); //checker

        }
    }
}
//Questions;
//Why we are writing the do first? Can't we write while first?