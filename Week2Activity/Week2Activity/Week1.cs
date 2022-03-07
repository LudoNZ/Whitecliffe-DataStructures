using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataStruct_Weekly
{
    static class Week1
    {
        //Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum
        public static int Activity1(int int1, int int2)
        {
            int result = IsDevisibleBy2or3(int1) && IsDevisibleBy2or3(int2)
                            ? int1 * int2
                            : int1 + int2;

            return result;
        }

        static bool IsDevisibleBy2or3(int check)
        {
            return check % 2 == 0 || check % 3 == 0;
        }

        static bool Activity1_Test(int int1, int int2, int expectedResult)
        {
            return expectedResult == Activity1(int1, int2);
        }

        public static void Activity1_AutoTest()
        {
            Console.WriteLine("\nWeek1 Activity 1 Tests:");
            Console.WriteLine(Activity1_Test(2, 3, 6));
            Console.WriteLine(Activity1_Test(1, 3, 4));
            Console.WriteLine(Activity1_Test(9, 6, 54));
            Console.WriteLine(Activity1_Test(8, 5, 13));
            Console.WriteLine(Activity1_Test(20, 30, 600));
            Console.WriteLine(Activity1_Test(2, 4, 8));
            Console.WriteLine(Activity1_Test(7, 3, 10));
        }


        //Write a Temperature conversion program that converts Celsius to Fahrenheit and vice versa.
        public static string Activity2(float degree, string FOrC)
        {
            string result;

            if (FOrC == "f")
            {
                result = ((degree - 32) / 1.8).ToString("0.##");
            }
            else if (FOrC == "c")
            {
                result = (degree * 1.8f + 32f).ToString("0.##");
            }
            else
            {
                result = "please enter f or c as unit";
            }

            //Console.WriteLine($"\ninput = {degree} {FOrC} \n" +
            //                    $"  result: {result}");
            return result;
        }

        static bool Activity2_Test(float degree, string FOrC, string expectedResult)
        {
            return expectedResult == Activity2(degree, FOrC);
        }

        public static void Activity2_AutoTest()
        {
            Console.WriteLine("\nActivity2 Auto Tests:");
            Console.WriteLine(Activity2_Test(32f, "f", "0"));
            Console.WriteLine(Activity2_Test(100f, "f", "37.78"));
            Console.WriteLine(Activity2_Test(-60f, "f", "-51.11"));
            Console.WriteLine(Activity2_Test(0f, "c", "32"));
            Console.WriteLine(Activity2_Test(32f, "c", "89.6"));
            Console.WriteLine(Activity2_Test(89f, "c", "192.2"));
            Console.WriteLine(Activity2_Test(89f, "k", "please enter f or c as unit"));
        }


        //Write a C# program that takes 10 numbers as input from user and find their sum and average
        public static void Activity3()
        {
            int[] myList = new int[10];

            //input 10 numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter Number {i + 1} of 10: ");
                myList[i] = int.Parse(Console.ReadLine());
            }

            //display result
            Console.WriteLine($"Sum = {ListSum(myList)} \nAverage = {ListAverage(myList)}");
        }

        static int ListSum(int[] myList)
        {
            //calc sum
            int sum = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                sum += myList[i];
            }

            return sum;
        }

        static float ListAverage(int[] myList)
        {
            return ListSum(myList) / myList.Length;
        }

        static bool Activity3_Test(int[] myList, int expectedSum, int expectedAv)
        {
            return ListSum(myList) == expectedSum && ListAverage(myList) == expectedAv;
        }

        public static void Activity3_AutoTest()
        {
            Console.WriteLine("\nActivity3 Auto Tests:");

            int expectedSum;
            int expectedAv;

            int[] myList1 = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            expectedSum = 50;
            expectedAv = 5;
            Console.WriteLine(Activity3_Test(myList1, expectedSum, expectedAv));

            int[] myList2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            expectedSum = 55;
            expectedAv = 5;
            Console.WriteLine(Activity3_Test(myList2, expectedSum, expectedAv));

            int[] myList3 = { 8, 40, 21 };
            expectedSum = 69;
            expectedAv = 23;
            Console.WriteLine(Activity3_Test(myList3, expectedSum, expectedAv));
        }


        //Write a program in C# Sharp to display the multiplication table of a given integer.
        public static void Activity4(int input)
        {
            Console.WriteLine("\nActivity4 :");

            string[] multiTable = CreateTable(input);

            PrintTable<string>(multiTable);
        }

        public static void Activity4_AutoTest()
        {
            Console.WriteLine("\nActivity4 Auto Tests:");

            int input = 4;

            string[] expectedValue = {
                "4 X 1 = 4",
                "4 X 2 = 8",
                "4 X 3 = 12",
                "4 X 4 = 16",
                "4 X 5 = 20",
                "4 X 6 = 24",
                "4 X 7 = 28",
                "4 X 8 = 32",
                "4 X 9 = 36",
                "4 X 10 = 40",
                "4 X 11 = 44",
                "4 X 12 = 48"};

            Console.WriteLine(ArrayMatch<string>(expectedValue, CreateTable(input)));

            input = 12;

            expectedValue = new string[] {
                "12 X 1 = 12",
                "12 X 2 = 24",
                "12 X 3 = 36",
                "12 X 4 = 48",
                "12 X 5 = 60",
                "12 X 6 = 72",
                "12 X 7 = 84",
                "12 X 8 = 96",
                "12 X 9 = 108",
                "12 X 10 = 120",
                "12 X 11 = 132",
                "12 X 12 = 144"};

            Console.WriteLine(ArrayMatch<string>(expectedValue, CreateTable(input)));

            input = 100;

            expectedValue = new string[] {
                "100 X 1 = 100",
                "100 X 2 = 200",
                "100 X 3 = 300",
                "100 X 4 = 400",
                "100 X 5 = 500",
                "100 X 6 = 600",
                "100 X 7 = 700",
                "100 X 8 = 800",
                "100 X 9 = 900",
                "100 X 10 = 1000",
                "100 X 11 = 1100",
                "100 X 12 = 1200"};

            Console.WriteLine(ArrayMatch<string>(expectedValue, CreateTable(input)));


        }

        static string[] CreateTable(int input)
        {
            string[] multiTable = new string[12];

            for (int i = 1; i <= 12; i++)
            {
                multiTable[i - 1] = $"{input} X {i} = {i * input}";
            }
            return multiTable;
        }

        public static void PrintTable<T>(T[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }


        public static bool ArrayMatch<T>(T[] array1, T[] array2)
        {
            bool match = true;

            int length = array1.Length;

            match = (length == array2.Length);

            int i = 0;

            while (match && i < length)
            {
                match = array1[i].Equals(array2[i]);

                i++;
            }

            return match;
        }


        public static string[] Activity5(int input1, int input2) 
        {
        
            string[] result = new string[] {
                $"Arithmetic operations on the given numbers:",
                    $"{input1} + {input2} = {input1 + input2}",
                    $"{input1} - {input2} = {input1 - input2}",
                    $"{input1} x {input2} = {input1 * input2}",
                    $"{input1} / {input2} = {input1 / input2}",
                    $"{input1} mod {input2} = {input1 % input2}"
                    };

            return result;
        }

        static bool Activity5_Test(int input1, int input2, string[] expectedOutput)
        {
            return ArrayMatch<string>(Activity5(input1, input2), expectedOutput);
        }

        public static void Activity5_AutoTest()
        {
            Console.WriteLine("\nActivity5 Auto Tests:");

            int input1, input2;
            string[] expectedResult;


            input1 = 2;
            input2 = 4;
            expectedResult = new string[]{
                "Arithmetic operations on the given numbers:",
                "2 + 4 = 6",
                "2 - 4 = -2",
                "2 x 4 = 8",
                "2 / 4 = 0",
                "2 mod 4 = 2" };

            Console.WriteLine(Activity5_Test(input1, input2, expectedResult));


            input1 = 4;
            input2 = 4;
            expectedResult = new string[]{
                "Arithmetic operations on the given numbers:",
                "4 + 4 = 8",
                "4 - 4 = 0",
                "4 x 4 = 16",
                "4 / 4 = 1",
                "4 mod 4 = 0" };

            Console.WriteLine(Activity5_Test(input1, input2, expectedResult));


            input1 = 10;
            input2 = 13;
            expectedResult = new string[]{
                "Arithmetic operations on the given numbers:",
                "10 + 13 = 23",
                "10 - 13 = -3",
                "10 x 13 = 130",
                "10 / 13 = 0",
                "10 mod 13 = 10" };

            Console.WriteLine(Activity5_Test(input1, input2, expectedResult));
            


        }
    }
}