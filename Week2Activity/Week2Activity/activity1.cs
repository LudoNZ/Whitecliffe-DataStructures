using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class activity1
    {
        static int[] numbers;

        public static void Compute()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number { i + 1 } of 10:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }


            Console.Write("Elements in array are: ");

            for (int i = 0; i < 10; i++) Console.Write($" {numbers[i]}");

            Console.ReadLine();
        }
    }
}
