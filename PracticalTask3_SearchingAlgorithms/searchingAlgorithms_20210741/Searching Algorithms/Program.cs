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
            //welcome message
            Console.WriteLine("Hello World! lets get searching!");

            //build array containing movie Titles
            ObtainRecords.Build();

            //Print List
            //ObtainRecords.PrintList(movieList);


            //Search For elements
            LinearSearch linearSearch = new LinearSearch();

            int index = linearSearch.Find(movieList, "enough" +
                "");

            Console.WriteLine($"\n Movie Found: {movieList[index]}");


            BinarySearch binarySearch = new BinarySearch();

            index = binarySearch.IterativeFind(movieList, "mermaid");

            string result;
            result = (index == -1) ? "NO MATCH FOUND"
                                    : movieList[index] ;

            Console.WriteLine($"Iterative Binary Search result: {result}");


        }
    }
}
