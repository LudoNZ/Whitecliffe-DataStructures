using System;
using System.Collections;
using System.Collections.Generic;

namespace BubbleSortCustomerData
{
    class Program
    {

        static List<Customer> myList = new List<Customer>();

        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to the wonderfull world of Sorting Algorithms!");

            //Hardcoded Dataset
            string[] dataSet = {"Tama, customer rating 2, address Auckland",
                                "Amelia, customer rating 5, address Taranaki",
                                "Kaos, customer rating 3, address Hamilton",
                                "Karl, customer rating 4, address Papatoetoe",
                                "Carlos, customer rating 5, address Glenfield",
                                "Alicia, customer rating 2, address Whangarei",
                                "Zion, customer rating 2, address Wellington",
                                "Sara, customer rating 3, address Auckland",
                                "Bob, customer rating 4, address Papakura",
                                "Wiremu, customer rating 5, address Auckland" };

            //Populate List
            foreach (string element in dataSet)
            {
                string[] split = (element.Split(','));
                Customer customer = new Customer(split[0], split[1], split[2]);
                myList.Add(customer);
            }

            //Display the original(unsorted) collection.
            Console.WriteLine("\n***Display the original(unsorted) collection.***");
            foreach (Customer customer in myList)
            {
                Console.WriteLine($"{customer.name}, {customer.rating}, {customer.address}");
            }

            //Use a bubble sort.
            int counter = 0;

            // for each customer in myList
            for (int j = 0; j < myList.Count - 1; j++)
            {
                for (int i = 0; i < myList.Count - 1 - j; i++)
                {
                    //get values to compare
                    int rL1 = myList[i].rating.Length;
                    int r1 = myList[i].rating[rL1 - 1];

                    int rL2 = myList[i + 1].rating.Length;
                    int r2 = myList[i + 1].rating[rL2 - 1];

                    //The magic
                    if (r1 > r2)
                    {
                        Customer temp = myList[i];
                        myList[i] = myList[i + 1];
                        myList[i + 1] = temp;
                    }
                    counter++;
                }
            }
            Console.WriteLine($"\n####Bubble Sort comparisons: {counter}");

            Console.WriteLine("\n***Display the Sorted collection. Customer Ranking Ascending***");
            foreach (Customer customer in myList)
            {
                Console.WriteLine($"{customer.name}, {customer.rating}, {customer.address}");
            }

            Console.ReadLine();
        }
    }


}



