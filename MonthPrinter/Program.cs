using System;
using System.Reflection.PortableExecutable;

namespace MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that receives an integer and prints the matching month.
            // If the number is more than 12 or less than 1, print "Error!".
            //Input
            //You will receive a single integer on a single line.
            //Output
            //If the number is within the boundaries, print the corresponding month, otherwise print "Error!".
            //January February March April May June July August September  October November December
            int num = int.Parse(Console.ReadLine());
            if(num == 1) { Console.WriteLine("January"); }
            else if(num == 2) { Console.WriteLine("February"); }
            else if (num == 3) { Console.WriteLine("March"); }
            else if(num == 4) { Console.WriteLine("April"); }
            else if(num == 5) { Console.WriteLine("May"); }
            else if(num == 6) { Console.WriteLine("June"); }
            else if (num == 7) { Console.WriteLine("July"); }
            else if (num == 8) { Console.WriteLine("August"); }
            else if (num == 9) { Console.WriteLine("September"); }
            else if (num == 10) { Console.WriteLine("October"); }
            else if (num == 11) { Console.WriteLine("November"); }
            else if(num == 12) { Console.WriteLine("December"); }
            else { Console.WriteLine("Error!"); }

        }
    }
}
