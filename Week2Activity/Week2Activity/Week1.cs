using System;
using System.Collections.Generic;
using System.Text;

namespace DataStruct_Weekly
{
    static class Week1
    {
        //Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum
        public static void Activity1(int int1, int int2)
        {
            int result = IsDevisibleBy2or3(int1) && IsDevisibleBy2or3(int2) 
                            ? int1 * int2 
                            : int1 + int2;

            Console.WriteLine(result);
        }

        static bool IsDevisibleBy2or3(int check)
        {
            return check % 2 == 0 || check % 3 == 0;
        }

    }
}