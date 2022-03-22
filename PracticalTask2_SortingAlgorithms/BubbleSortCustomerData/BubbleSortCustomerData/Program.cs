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
            Console.WriteLine("\n***Display the original(unsorted) collection.***");
            Customer.DisplayList(myList);

            //USING BUBBLE SORT.....

            //Sort by Customer rating ascending
            Customer.BubbleSort(myList, "rating", true);
            Console.WriteLine("\n***sort rating ascending***");
            Customer.DisplayList(myList);

            Customer.BubbleSort(myList, "rating", false);
            Console.WriteLine("\n***sort rating descending***");
            Customer.DisplayList(myList);

            //Sort by Customer.name descending
            Customer.BubbleSort(myList, "name", false);
            Console.WriteLine("\n***sort name descending***");
            Customer.DisplayList(myList);


            Console.ReadLine();
        }
    }


}



