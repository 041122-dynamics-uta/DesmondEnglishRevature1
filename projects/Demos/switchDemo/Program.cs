using System;

namespace switchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The default keyword is optional and specifies some code to run 
                if there is no case match: */

            Console.WriteLine("Who is the best AVENGER?");

            Console.ReadLine();

            int avenger = 3;
            switch (avenger)
            {
                case 4:
                    Console.WriteLine("Black Panther is the best AVENGER!");
                    break;
                case 5:
                    Console.WriteLine("Spider-Man is the best AVENGER!");
                    break;
                case 6:
                    Console.WriteLine("Doctor Strange is the best AVENGER!");
                    break;
                case 7:
                    Console.WriteLine("Vision is the best AVENGER!");
                    break;
                case 8:
                    Console.WriteLine("Moon Knight is the best AVENGER!");
                    break;
                default:
                    Console.WriteLine("Wanda is the only answer for best AVENGER!");
                    break;
            }
            // Outputs "Wanda is the only answer for best AVENGER!"
        }
    }
}
