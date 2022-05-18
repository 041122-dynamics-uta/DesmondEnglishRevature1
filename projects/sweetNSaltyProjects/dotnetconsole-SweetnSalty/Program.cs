using System;
using System.Collections.Generic;

namespace SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the start and stop numbers (the range) from the user.
            Console.WriteLine("Entering a Range! Give me your first number?");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exiting a Range! Give me a second number");
            int second = Convert.ToInt32(Console.ReadLine());
            
            //Get the quantity of numbers you will print per line from the user.
            Console.WriteLine();
        }
    }
}

// Requirements:
// Include verbose commentary in the source code to tell me what each few lines are doing.

// Print the numbers in groups of what the user says per line with one space separating each number.
// If the number is a multiple of three, print “Sweet” (instead of the number) to the console.    
// If the number is a multiple of five, print “Salty” (instead of the number) to the console.    
// For numbers which are multiples of both three and five, print “Sweet’nSalty” to the console (instead of the number).
// After the numbers have all been printed to the console, print to the console on 3 separate lines:
// how many "Sweet",
// how many "Salty", and
// how many "Sweet’nSalty"

// 'Sweet', 'Salty', and 'Sweet'nSalty' are three separate groups, so "Sweet’nSalty" does not increment "Sweet" or "Salty" (and vice versa).