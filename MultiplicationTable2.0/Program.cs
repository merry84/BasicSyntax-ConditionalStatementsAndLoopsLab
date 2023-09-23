using System;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пренапишете програмата от предишната задача, за да може да получи множителя от конзолата.
            //Отпечатайте таблицата с множителя в интервала от даденото число до 10.
            //Ако дадения множител е повече от 10, отпечатайте само един ред с цялото число,
            //.дадения множител и произведението. Вижте примерите по-долу за повече информация.
            // Rewrite the program from the previous task so it can receive the multiplier from the console.
            // Print the table with the multiplier in the interval from the given number to 10.
            // If the given multiplier is more than 10, print only one row with the integer,
            // the given multiplier, and the product.See the examples below for more information.
            //Output
            //Print every row of the table in the following format:
            //{ theInteger} X { times} = { product}
            //   Constraints
            //•	The integer will be in the interval[1…100]
            int num1 = int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
                num2++;

            } while (num2 <= 10);
            

        }
    }
}
