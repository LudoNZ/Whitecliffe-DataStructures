using System;
using System.Collections.Generic;

namespace Searching_Algorithms
{
    class Program
    {
        static int testCounter;

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



            string result;
            int index;

            //Linear Search For elements
            LinearSearch linearSearch = new LinearSearch();
            index = linearSearch.Find(movieList, "enough");

            result = (index == -1) ? "NO MATCH FOUND"
                                    : movieList[index];
            Console.WriteLine($"\n Linear Search result: {result}");

            //Binary Search
            BinarySearch binarySearch = new BinarySearch();

            //Iterative Search
            index = binarySearch.IterativeFind(movieList, "mermaid");


            result = (index == -1) ? "NO MATCH FOUND"
                                    : movieList[index];

            Console.WriteLine($"Iterative Binary Search result: {result}");

            index = binarySearch.RecursiveFind(movieList, "mermaid", 0, movieList.Length);

            Console.WriteLine("\n****Testing Testing****");

            Test("linear", "enough", "enough said");
            Test("linear", "mermaid", "Little Mermaid");
            Test("linear", "negative test", "NO RESULT FOUND");

        }

        static void Test(string searchType, string testInput, string expectedResult)
        {
            testCounter++;

            string result;
            int index;
            LinearSearch linearSearch = new LinearSearch();

            //Select Search algorithm
            switch (searchType)
            {
                case "linear":
                    index = linearSearch.Find(movieList, testInput);
                    result = (index >= 0)
                            ? movieList[index]
                            :"NO RESULT FOUND";

                    break;
                default:
                    result = movieList[linearSearch.Find(movieList, testInput)];
                    break;
            }

            string report = (result == expectedResult)
                            ? "TRUE"
                            : $"FALSE     actual result: {result}";

            //Print Test Report 
            Console.WriteLine($"\nTest {testCounter} complete: {searchType}\n" +
                $"  find: {testInput}     expect: {expectedResult}\n" +
                $"  result: {report}");

        }
    }
}
