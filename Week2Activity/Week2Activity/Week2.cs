using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Week2
    {
        public static void Activity1()
        //Write a program in C# that ask a user to enter 10 integer numbers (use an array store those numbers in an array and print those numbers.
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number { i + 1 } of 10:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");

            for (int i = 0; i < 10; i++) 
            {
                Console.Write($" {numbers[i]}");
            }

            Console.ReadLine();
        }

        public static void Activity2()
        //Write a program in C# to read n number of values in an array and display it in reverse order
        {
            //Gather Array size from user
            Console.Write("Input the number of elements to store in the array: ");

            int nElement = int.Parse(Console.ReadLine());

            int[] values = new int[nElement];

            Console.WriteLine($"Input { nElement } number of elements in the array:");

            //Gather List Input
            for(int i = 0; i < nElement; i++)
            {
                Console.Write($"element - { i }: ");
                values[i] = int.Parse(Console.ReadLine());
            }


            //Print List
            Console.Write("\nThe numbers stored in the array are:");
            for (int i = 0; i < nElement; i++)
            {
                Console.Write($" {values[ i ]}");
            }

            //Print List in Reverse
            Console.Write("\nThe values stored into the array in reverse are:");
            for (int i = nElement -1 ; i > -1; i--)
            {
                Console.Write($" {values[i]}");
            }
        }
    }
}
