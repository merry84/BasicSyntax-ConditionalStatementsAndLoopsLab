using System;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints on a new line the next n odd numbers(starting from 1).
            //On the last row print the sum of all n odd numbers.
            //Input
            //A single number n is read from the console, indicating how many odd numbers need to be printed.
            //Output
            //Print the next n odd numbers, starting from 1, separated by new lines.On the last line,
            //print the sum of these numbers.
            //Constraints
            //•	n will be in the interval[1…100]
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int odd = i * 2 - 1;
                Console.WriteLine($"{odd}");
                sum += odd;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
