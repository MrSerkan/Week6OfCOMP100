using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program to add the user input and display the sum at the end,
 * The program should stop when the user enters an even number.
 */

namespace D4_using_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool allOdds = true;
            do
            {
                Console.WriteLine("Enter you number (even to end): ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0) // even
                {
                    allOdds = false;
                }//stop
                else
                {
                    sum = sum + input;
                }// add to sum
            } while (allOdds);
            Console.WriteLine($"Sum: {sum} ");
        }
    }
}
