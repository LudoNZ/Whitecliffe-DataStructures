using System;
using System.Collections;
using System.Collections.Generic;

namespace BubbleSortCustomerData
{
    class Program
    {
        //declare list
        public static List<Customer> myList = new List<Customer>();

        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to the wonderfull world of Sorting Algorithms!");

            //Collect data
            string[] dataSet = Customer.UpLoad();

            //Populate List
            Customer.ConstructList(dataSet);

            //Display the original(unsorted) collection.
            Customer.DisplayList(myList);

            //Use a bubble sort.

            //Sort by Customer rating ascending
            Customer.BubbleSortRating(myList);

            //Sort by Customer.name descending


            Console.WriteLine("\n***Display the Sorted collection. Customer Ranking Ascending***");
            foreach (Customer customer in myList)
            {
                Console.WriteLine($"{customer.name}, {customer.rating}, {customer.address}");
            }

            Console.ReadLine();
        }
    }


}



