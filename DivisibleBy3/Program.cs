﻿using System;
using System.Runtime.Intrinsics.X86;

namespace DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which prints all the numbers from 1 to 100, that are divisible by 3.
            //You have to use a single for loop.
            //The program should not receive input.
            for (int i = 3; i <= 100; i+=3)
            {                           
                    Console.WriteLine(i);
            }
        }
    }
}
