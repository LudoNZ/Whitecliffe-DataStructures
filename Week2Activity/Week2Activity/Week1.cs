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

        public static bool Activity1_Test(int int1, int int2, int expectedResult)
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

    }
}