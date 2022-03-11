using System;
using System.Collections.Generic;
using System.Text;

namespace DataStruct_Weekly
{
    class Week2
    {
        //Write a program in C# that ask a user to enter 10 integer numbers (use an array store those numbers in an array and print those numbers.
        public static void Activity1()
        {
            Console.WriteLine("\nActivity1");

            int[] numbers = new int[10];

            //input 10 numbers from user
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number { i + 1 } of 10:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //print array
            Console.Write("Elements in array are: ");
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {numbers[i]}");
            }

            Console.ReadLine();
        }

        //Write a program in C# to read n number of values in an array and display it in reverse order
        public static void Activity2()
        {
            Console.WriteLine("\nActivity2");

            //input Array size from user
            Console.Write("Input the number of elements to store in the array: ");

            int nElement = int.Parse(Console.ReadLine());

            int[] values = new int[nElement];

            Console.WriteLine($"Input { nElement } number of elements in the array:");

            //input List Data
            for (int i = 0; i < nElement; i++)
            {
                Console.Write($"element - { i }: ");
                values[i] = int.Parse(Console.ReadLine());
            }


            //Print List
            Console.Write("\nThe numbers stored in the array are:");
            for (int i = 0; i < nElement; i++)
            {
                Console.Write($" {values[i]}");
            }

            //Print List in Reverse
            Console.Write("\nThe values stored into the array in reverse are:");
            for (int i = nElement - 1; i > -1; i--)
            {
                Console.Write($" {values[i]}");
            }
        }

        //Write a C# program that prints the multiplication tables from 1 to 12. Each row should display 4 tables with proper format.
        public static void Activity3()
        {
            Console.WriteLine("\nActivity3");

            //Loop through each line of tables
            for (int j = 0; j < 12; j += 4)
            {
                //for each row x12 of each set of tables
                for (int row = 1; row < 13; row++)
                {

                    for (int i = 1 + j; i < j + 5; i++)
                    {
                        Console.Write($" {Week2.ReLength(i, 5)} x {Week2.ReLength(row, 2)} = {Week2.ReLength(i * row, 3)} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        //add blank space to strings for uniform size
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

        //Write a C# program to create LinkedList that ask user input and display user values in forward and reverse order.
        public static void Activity4()
        {
            Console.WriteLine("\nActivity4");

            LinkedList<string> mylist = new LinkedList<string>();

            //input Length of List
            Console.Write("\nInput the number of nodes: ");
            int nodes = int.Parse(Console.ReadLine());

            //input data to populate list
            for (int i = 0; i < nodes; i++)
            {
                Console.Write($"input data for node {i + 1}: ");
                mylist.AddLast(Console.ReadLine());
            }

            //print list items
            Console.WriteLine("\nData Entered in the list:");
            foreach (string item in mylist)
            {
                Console.WriteLine($"Data = {item}");

            }

            Console.WriteLine("\nThe List in forward order is:");
            //Show list in order
            LinkedListNode<string> currentNode = mylist.First;

            do
            {
                Console.WriteLine($"Data: {currentNode.Value}");
                currentNode = currentNode.Next;
            }
            while (currentNode != null);


            Console.WriteLine("\nThe List in reverse order is:");
            //Show list in reverse order
            currentNode = mylist.Last;

            do
            {
                Console.WriteLine($"Data = {currentNode.Value}");
                currentNode = currentNode.Previous;
            }
            while (currentNode != null);
        }

        public static void Activity5()
            { //LinkedList<T> myList = new LinkedList<T>();

            }

    }
}
