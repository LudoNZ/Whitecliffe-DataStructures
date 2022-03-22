using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortCustomerData
{
    class Customer
    {
        public string name, rating, address;

        public Customer(string Name, string Rating, string Address)
        {
            this.name = Name;
            this.rating = Rating;
            this.address = Address;
        }

        public static string[] UpLoad()
        {
            //Hardcoded Dataset
            string[] data = {"Tama, customer rating 2, address Auckland",
                                "Amelia, customer rating 5, address Taranaki",
                                "Kaos, customer rating 3, address Hamilton",
                                "Karl, customer rating 4, address Papatoetoe",
                                "Carlos, customer rating 5, address Glenfield",
                                "Alicia, customer rating 2, address Whangarei",
                                "Zion, customer rating 2, address Wellington",
                                "Sara, customer rating 3, address Auckland",
                                "Bob, customer rating 4, address Papakura",
                                "Wiremu, customer rating 5, address Auckland" };

            return data;
        }

        public static void ConstructList(string[] data)
        {
            foreach (string element in data)
            {
                string[] split = (element.Split(','));
                Customer customer = new Customer(split[0], split[1], split[2]);
                Program.myList.Add(customer);
            }
        }

        public static void DisplayList(List<Customer> list)
        {
            Console.WriteLine("\n***Display the original(unsorted) collection.***");
            foreach (Customer c in list)
            {
                Console.WriteLine($"{c.name}, {c.rating}, {c.address}");
            }
        }

        public static void BubbleSortRating(List<Customer> list)
        {
            int counter = 0;

            // for each customer in myList
            for (int j = 0; j < list.Count - 1; j++)
            {
                //bool to check if array is sorted for early break.
                bool sorted = true;

                for (int i = 0; i < list.Count - 1 - j; i++)
                {

                    //get values to compare
                    int r1L = list[i].rating.Length - 1;
                    int r1 = list[i].rating[r1L];

                    int r2L = list[i + 1].rating.Length - 1;
                    int r2 = list[i + 1].rating[r2L];

                    //The Swap check
                    if (r1 > r2)
                    {
                        sorted = false;
                        Customer temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                    counter++;
                }
                //check if Array items are in order.
                if (sorted == true)
                {
                    Console.WriteLine($"\nBreak Early. j = {j}");
                    break;
                }
            }
            Console.WriteLine($"\n####Bubble Sort comparisons: {counter}");

        }

        public static void BubbleSortName(List<Customer> list)
        {
            int counter = 0;

            // for each customer in myList
            for (int j = 0; j < list.Count - 1; j++)
            {
                //bool to check if array is sorted for early break.
                bool sorted = true;

                for (int i = 0; i < list.Count - 1 - j; i++)
                {
                    //get values to compare
                    string r1 = list[i].name;
                    string r2 = list[i + 1].name;

                    //The Swap check
                    if (r1 > r2)
                    {
                        sorted = false;
                        Customer temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                    counter++;
                }
                //check if Array items are in order.
                if (sorted == true)
                {
                    Console.WriteLine($"\nBreak Early. j = {j}");
                    break;
                }
            }
            Console.WriteLine($"\n####Bubble Sort comparisons: {counter}");

        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs; rhs = temp;
        }
    }
}
