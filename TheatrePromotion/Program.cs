using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // A theatre sails tickets at discount and a program is needed to calculate the price of a single ticket.
                // If the given age does not fit one of the categories, you should print "Error!".
                //The prices of the tickets are as follows:

                //Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
                //Weekday       12$             	18$         	12$
                //Weekend       15$	                20$	            15$
                //Holiday       5$	                12$	            10$

                //Input
                //The input comes in two lines. On the first line you will receive the type of day.
                //On the second – the age of the person.
                //Output
                //Print the price of the ticket according to the table or "Error!", if the age is not in the table.
                //Constraints
                //•	The age will be in the interval[-1000…1000].
                //•	The type of day will always be valid. 
            
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int priceTicket = 0;
            if (day == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) { priceTicket = 12; }
                else if (age > 18 && age <= 64) { priceTicket = 18; }
            }
            if (day == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) { priceTicket = 15; }
                else if (age > 18 && age <= 64) { priceTicket = 20; }
            }
            if (day == "Holiday")
            {
                if (age >= 0 && age <= 18) { priceTicket = 5; }
                else if (age > 18 && age <= 64) { priceTicket = 12; }
                else if(age > 64 && age <= 122) { priceTicket = 10; }
            }
            if(priceTicket != 0) { Console.WriteLine($"{priceTicket}$"); }
            else { Console.WriteLine("Error!"); }
            //if(age < 0) { Console.WriteLine("Error!"); }
            //else { Console.WriteLine($"{priceTicket}$"); }

        }
    }
}
