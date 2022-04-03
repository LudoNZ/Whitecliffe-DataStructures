using System;
using System.Collections.Generic;

namespace Searching_Algorithms
{
    class Program
    {
        static int TestCounter;
        static double timeTaken;

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


            TestCounter = 0;

            Console.WriteLine("\n****Testing Linear Search****");

            Test("linear", "enough", "World Is Not Enough");
            Test("linear", "mermaid", "Little Mermaid");
            Test("linear", "negative test", "no result found");

            PrintStats();



        }

        static void Test(string searchType, string testInput, string expectedResult)
        {
            TestCounter++;

            string result;
            int index;
            LinearSearch linearSearch = new LinearSearch();
            BinarySearch binarySearch = new BinarySearch();

            System.Diagnostics.Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();

            //Select Search algorithm
            switch (searchType)
            {
                case "linear":
                    index = linearSearch.Find(movieList, testInput);
                    break;

                case "BinaryIterative":
                    index = binarySearch.IterativeFind(movieList, testInput);
                    break;

                case "BinaryRecursive":
                    index = binarySearch.RecursiveFind(movieList, testInput, 0, movieList.Length);
                    break;

                default:
                    index = linearSearch.Find(movieList, testInput);
                    break;
            }

            timer.Stop();
            timeTaken+= timer.ElapsedTicks;

            result = (index >= 0)
                            ? movieList[index]
                            : "no result found";

            string report = (result == expectedResult)
                            ? "TRUE"
                            : $"FALSE     actual result: {result}";

            //Print Test Report 
            Console.WriteLine($"\nTest {TestCounter} complete: {searchType}\n" +
                $"  find: {testInput}     expect: {expectedResult}\n" +
                $"  Time taken (ticks): {timer.ElapsedTicks}\n" +
                $"  result: {report}");

        }

        static void PrintStats()
        {
            Console.WriteLine($"\nTests results to average: {TestCounter}\n" +
                                $"Total Time taken (ticks): {timeTaken}\n" +
                                $"Average Time per test (ticks): {timeTaken / TestCounter}");
        }
    }
}
