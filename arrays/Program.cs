using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //immediate syntax
            string[] fruit = { "apples", "pears", "grapes" };
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            //array is declared but all indecies are null
            string[] names = new string[3];
            names[0] = "steve";
            names[1] = "dan";
            names[2] = "sam";
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            int[] weights = { 12, 34, 12, 54, 575, 34543 };
            double sum = weights.Sum();
            Console.WriteLine("The sum is: " + sum);
            double avg = weights.Average();
            Console.WriteLine("The sum is: " + avg);

            UseArray(names);
        }

        static void UseArray(string[] values)
        {
            Console.Write("values in method: ");
            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
