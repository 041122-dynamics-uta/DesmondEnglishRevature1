using System;
using System.Collections.Generic;
using System.Linq;

// Include verbose commentary in the source code to tell me what each few lines are doing.

namespace SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make it a function to easily recall it later and make it a loop for exiting purposes
            void Game () { 

            //Variable Declaration
            int newline = 0; // to print on new lines
            int sweet = 0;
            int salty = 0;
            int swns = 0;
            
            //Get the start and stop numbers (the range) from the user.
            Console.WriteLine("Entering a Range! Give me your first number?");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exiting a Range! Give me a second number");
            int second = Convert.ToInt32(Console.ReadLine());
            
            //Get the quantity of numbers you will print per line from the user.
            Console.WriteLine("How many numbers per line?");
            int howmany = Convert.ToInt32(Console.ReadLine());

            int range = second - first;

            
            // Alec explained to get a range using the LINQ library and IEnumerable
            IEnumerable<int> total = Enumerable.Range(first, range);

            // Print the numbers in groups of what the user says per line with one space separating each number.
            foreach (int i in total)
            {   
                
                if(newline == howmany)
                    {
                        Console.WriteLine();
                        newline = 0;
                    }

                    if(i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("Sweet'nSalty ");
                        swns++;
                    }
                    else if(i % 3 == 0)
                    {
                        Console.Write("Sweet ");
                        sweet++;
                    }
                    else if(i % 5 == 0)
                    {
                        Console.Write("Salty ");
                        salty++;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }

                    newline++;
            }
            // If the number is a multiple of three, print “Sweet” (instead of the number) to the console.    
            // If the number is a multiple of five, print “Salty” (instead of the number) to the console.    
            // For numbers which are multiples of both three and five, print “Sweet’nSalty” to the console (instead of the number).
            // After the numbers have all been printed to the console, print to the console on 3 separate lines:
            Console.WriteLine($"\nTotal ~ Sweet: {sweet}");
            Console.WriteLine($"\nTotal ~ Salty: {salty}");
            Console.WriteLine($"\nTotal ~ Sweet'nSalty: {swns}");

            // Able to restart within program, instead of exiting on default
            Console.WriteLine("Want to find the Trail Mix? 1 for YES 2 for NO");
            int answer = Convert.ToInt32(Console.ReadLine());

            if(answer == 1)
            {
                Game();
            }
            else
            {
                Environment.Exit(0);
            }
        }
                
            Game();
        }
    }
}

// Requirements:

// how many "Sweet",
// how many "Salty", and
// how many "Sweet’nSalty"
// 'Sweet', 'Salty', and 'Sweet'nSalty' are three separate groups, so "Sweet’nSalty" does not increment "Sweet" or "Salty" (and vice versa).