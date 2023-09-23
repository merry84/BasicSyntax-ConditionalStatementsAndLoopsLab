using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading;
using System.Timers;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that receives an integer as an input.Print the 10 times table for this integer.
            // See the examples below for more information.
            //Output
            //Print every row of the table in the following format:
            //{ theInteger} X { times} = { product}
            int input = int.Parse(Console.ReadLine());
            int time = 1;
            while (time <= 10)
            {
                Console.WriteLine($"{input} X {time} = { input * time}");
                time++;
            }
           
        }
    }
}
