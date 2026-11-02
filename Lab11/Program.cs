/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : 15
* Course     : GI113 Computer Programming (GI)
*/
using System;
namespace Lab11
{
    internal class Program
    {
        static int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
        static int sum;
        static float average;
        static int maximum;
        static int minimum;

        static void Main(string[] args)
        {
            //Part A
            Console.WriteLine("========== PART A ==========");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            maximum = numbers[0];
            minimum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }

                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }
            Console.ReadKey();

            //Part B           
            Console.WriteLine("========== PART B ==========");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            maximum = numbers[0];
            minimum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }

                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }
            Console.ReadKey();
        }
    }
}
