using System;
using System.Collections.Generic;

namespace Searching_Algorithms
{
    class Program
    {
        //a List to store movie Titles
        public static string[] movieList;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! lets get searching!");

            ObtainRecords.Build();

            ObtainRecords.PrintList(movieList);

        }
    }
}
