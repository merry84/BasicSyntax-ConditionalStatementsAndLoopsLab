using System;
using System.Diagnostics;

namespace PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modify the program from the previous problem, so it will print "Failed!", if the grade is lower than 3.00.
            //Input
            //The input comes as a single double number.
            //Output
            //The output is either "Passed!" if the grade is more than 2.99, otherwise you should print "Failed!".
            double num = double.Parse(Console.ReadLine());  
            if (num >= 3) { Console.WriteLine("Passed!"); }
            else { Console.WriteLine("Failed!"); }

        }
    }
}
