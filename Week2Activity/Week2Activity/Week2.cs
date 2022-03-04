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
            Console.WriteLine("\nActivity1:");

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
            Console.WriteLine("\nActivity2:");

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

        public static void Activity3()
        //Write a C# program that prints the multiplication tables from 1 to 12. Each row should display 4 tables with proper format.
        {
            Console.WriteLine("\nActivity3:");

            for (int j = 0; j < 12; j+=4)
            {//each set of tables

                for (int row = 1; row < 13; row++)
                {//each row
                    for (int i = 1 + j; i < j + 5; i++)
                    {//fill 4x tables
                        Console.Write($" {Week2.ReLength(i, 5)} x {Week2.ReLength(row, 2)} = {Week2.ReLength(i * row, 3)} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private static string ReLength(int input, int finalLength)
        {
            string result = Convert.ToString(input);

            int add = finalLength - result.Length;

            for (int i = add; i > 0; i--)
            {
                result = " " + result;
            } 

            return result;
        }
    }
}
