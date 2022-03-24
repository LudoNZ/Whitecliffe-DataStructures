using BuiltInSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuickSort
{
    class QuickSort
    {
        //Static Counters
        private static int CountComparisons;
        private static int CountExchanges;

        //Timer results list
        private static List<long> TimerList = new List<long> { };

        private CatalogueItem[] items;
        private int number;
        public void Sort(CatalogueItem[] values)
        {
            // check for empty or null array
            if (values == null || values.Length == 0)
            {
                return;
            }

            //Start a Timer
            System.Diagnostics.Stopwatch timerSort = System.Diagnostics.Stopwatch.StartNew();

            //set Static Counter sefault value
            CountComparisons = 0;
            CountExchanges = 0;

            items = values;
            number = values.Length;
            Quicksort(0, number - 1);

            //stop timer
            timerSort.Stop();

            //Add value to list
            TimerList.Add(timerSort.ElapsedTicks);

            string timeTaken = timerSort.ElapsedMilliseconds > 0
                                ? timerSort.ElapsedMilliseconds.ToString()
                                : "0 milliseconds, pretty fast eh!";

            string ticksTaken = timerSort.ElapsedTicks.ToString();

            Console.WriteLine($"**Quick Sort complete:\n" +
                                $"  number of Comparisons made: {CountComparisons}\n" +
                                $"  number of Exchanges executed: {CountExchanges}\n" +
                                $"  elapsed time(Milliseconds): {timeTaken}\n" +
                                $"  elapsed ticks(10,000 per millisecond): {ticksTaken}\n");
        }

        private void Quicksort(int low, int high)
        {
            int i = low, j = high;
            // Get the pivot element from the middle of the list
            int pivot = items[low + (high - low) / 2].Id;
            
            // Divide into two lists
            while (i <= j)
            {
                // If the current value from the left list is smaller than the pivot
                // element then get the next element from the left list
                while (items[i].Id < pivot)
                {
                    i++;

                    CountComparisons++;
                }
                // If the current value from the right list is larger than the pivot
                // element then get the next element from the right list
                while (items[j].Id > pivot)
                {
                    j--;

                    CountComparisons++;
                }
                // If we have found a value in the left list which is larger than
                // the pivot element and if we have found a value in the right list
                // which is smaller than the pivot element then we exchange the
                // values.
                // As we are done we can increase i and j
                if (i <= j)
                {
                    Exchange(i, j);
                    i++;
                    j--;
                }
            }
            // Recursion
            if (low < j)
                Quicksort(low, j);
            if (i < high)
                Quicksort(i, high);
        }
        private void Exchange(int i, int j)
        {
            CountExchanges++;

            CatalogueItem temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
        /* Prints the array */
        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                "id: " + arr[i].Id + " "
                + "name: " + arr[i].ItemName + " "
                + "category: " + arr[i].Category + "\n");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Start a Timer to track entire excercise
            System.Diagnostics.Stopwatch timerFull = System.Diagnostics.Stopwatch.StartNew();

            QuickSort ob = new QuickSort();
            CatalogueItem[] arr = { new CatalogueItem( 3, "Life of Pi","Books"),
                                    new CatalogueItem( 7, "Deelongie 4 way toaster","Home and Kitchen"),
                                    new CatalogueItem( 2, "Glorbarl knife set","Home and Kitchen"),
                                    new CatalogueItem( 4, "Diesorn vacuum cleaner","Appliances"),
                                    new CatalogueItem( 5, "Jennie Olivier sauce pan","Home and Kitchen"),
                                    new CatalogueItem( 6, "This book will save your life","Books"),
                                    new CatalogueItem( 9, "Kemwould hand mixer","Appliances"),
                                    new CatalogueItem( 1, "Java for Dummies","Books"),
                                    };


            Console.WriteLine("The Unsorted array is: \r\n");
            ob.PrintArray(arr);
            //apply sort
            ob.Sort(arr);
            Console.WriteLine("The Quick Sorted array is: \r\n");
            ob.PrintArray(arr);


            //Add extra Sort.

            //The same data as before but already sorted (the output from the previous task) best case
            ob.Sort(arr);
            Console.WriteLine("The Quick Sorted array is: \r\n");
            ob.PrintArray(arr);

            //The same data as before but sorted in reverse. worse case
            Console.WriteLine("Array reversed:");
            Array.Reverse(arr);
            ob.Sort(arr);
            ob.PrintArray(arr);

            //stop Full-timer and convert type to string
            timerFull.Stop();
            string timeTaken = timerFull.ElapsedMilliseconds > 0
                                ? timerFull.ElapsedMilliseconds.ToString()
                                : "0 milliseconds, somethings probably wrong...!";
            Console.WriteLine($"The entire duration(Milliseconds): {timeTaken} \r\n");

            long averageSortTime = CalclateAverage(TimerList);
            Console.WriteLine($"Average time taken to complete Sorts(ticks): {averageSortTime}");
            float avmill = averageSortTime / 10000;
            Console.WriteLine($"Average milliseconds: {avmill}");

            Console.Read();
        }

        private static long CalclateAverage(List<long> timeList)
        {
            long sum = 0;
            foreach (long timeLogged in TimerList)
            {
                sum += timeLogged;
            }

            return sum / TimerList.Count;
        }
    }
}