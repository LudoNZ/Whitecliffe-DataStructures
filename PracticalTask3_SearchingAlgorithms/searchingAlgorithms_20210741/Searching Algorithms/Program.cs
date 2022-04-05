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

            int index;

            //build initial small array containing movie Titles
            ObtainRecords.Build("moviesTopGrossing200", 200);

            //Linear Search For elements
            LinearSearch linearSearch = new LinearSearch();
            index = linearSearch.Find(movieList, "enough");
            PrintResult(movieList, index);

            //Instantiate Binary Search
            BinarySearch binarySearch = new BinarySearch();
                        
            //Iterative Search
            index = binarySearch.IterativeFind(movieList, "101 Dalmatians");
            PrintResult(movieList, index);

            //Recursive Search
            index = binarySearch.RecursiveFind(movieList, "Ace Ventura: When Nature Calls", 0, movieList.Length);
            PrintResult(movieList, index);

            AutoTest();
            

            //build Large enough array to gather valid timer results
            ObtainRecords.Build("movieTitles2million", 2000000);

            AutoTest();

        }

        static void Test(string searchType, string testInput, string expectedResult)
        {
            TestCounter++;

            string result;
            int index;
            LinearSearch linearSearch = new LinearSearch();
            BinarySearch binarySearch = new BinarySearch();

            //Time Test duration
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

            //Stop Timer
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
                //$"  Time taken (ticks): {timer.ElapsedTicks}\n" +
                $"  result: {report}");

        }

        static void AutoTest()
        {
            //Linear Search
            ResetStats();
            Console.WriteLine("\n****Testing Linear Search****");
            Test("linear", "enough", "World Is Not Enough");
            Test("linear", "mermaid", "Little Mermaid");
            Test("linear", "negative test", "no result found");
            PrintStats("Linear Search");
            ResetStats();

            //Binary Search, Iterative
            Console.WriteLine("\n****Testing Binary Iterative Search****");

            Test("BinaryIterative", "enough", "no result found");
            Test("BinaryIterative", "mermaid", "Little Mermaid");
            Test("BinaryIterative", "negative test", "no result found");
            PrintStats("Binary Search, Iterative");
            ResetStats();

            //Binary Search, Recursive
            Console.WriteLine("\n****Testing Binary Recursive Search****");
            Test("BinaryRecursive", "mermaid", "Little Mermaid");
            Test("BinaryRecursive", "enough", "no result found");
            Test("BinaryRecursive", "negative test", "no result found");
            Test("BinaryRecursive", "Ace Ventura: When Nature Calls", "Ace Ventura: When Nature Calls ");
            Test("BinaryRecursive", "101 Dalmatians", "101 Dalmatians ");
            PrintStats("Binary Search, Recursive");
            ResetStats();
        }

        static void PrintStats(string stats)
        {
            Console.WriteLine($"\n#### STATS REPORT #### {stats}\n" +
                                $"Tests results to average: {TestCounter}\n" +
                                $"Total Time taken (ticks): {timeTaken}\n" +
                                $"Average Time per test (ticks): {timeTaken / TestCounter}\n\n");
        }

        static void PrintResult(string[] array, int index)
        {
            string result = (index == -1) 
                            ? "NO MATCH FOUND"
                            : array[index];

        Console.WriteLine($"\nSearch result: {result}");
        }

        static void ResetStats()
        {
            TestCounter = 0;
            timeTaken = 0;
        }
    }
}
