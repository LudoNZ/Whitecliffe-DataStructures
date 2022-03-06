using System;
using System.Collections.Generic;
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

            if(FOrC == "f")
            {
                result = ((degree - 32) / 1.8).ToString("0.##");
            }
            else if(FOrC == "c")
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
            for(int i = 0; i < 10; i++)
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

            int[] myList3 = { 8, 40, 21};
            expectedSum = 69;
            expectedAv = 23;
            Console.WriteLine(Activity3_Test(myList3, expectedSum, expectedAv));
        }
    }



    
}