using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortCustomerData
{
    class Customer
    {
        public string Name, Rating, Address;

        public Customer(string name, string rating, string address)
        {
            this.Name = name;
            this.Rating = rating;
            this.Address = address;
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
            foreach (Customer c in list)
            {
                Console.WriteLine($"{c.Name}, {c.Rating}, {c.Address}");
            }
        }

        public static void BubbleSort(List<Customer> list, string property, bool ascending)
        {
            int comparisons = 0;

            // for each customer in myList
            for (int confirmed = 0; confirmed < list.Count - 1; confirmed++)
            {
                //reset status to true for early break.
                bool sorted = true;

                //for each customer in list
                for (int customer = 0; customer < list.Count - 1 - confirmed; customer++)
                {
                    int r1 = 0;
                    int r2 = 0;

                    //Get Property values
                    switch (property)
                    {
                        case "rating" :
                            //get values to compare
                            int r1L = list[customer].Rating.Length - 1;
                            r1 = list[customer].Rating[r1L];

                            int r2L = list[customer + 1].Rating.Length - 1;
                            r2 = list[customer + 1].Rating[r2L];
                            break;

                        case "name":
                            int[] rank = Alphabetise(list[customer].Name, list[customer + 1].Name);
                                r1 = rank[0];
                                r2 = rank[1];
                            break;

                        case "address":
                            rank = Alphabetise(list[customer].Address, list[customer + 1].Address);
                            r1 = rank[0];
                            r2 = rank[1];
                            break;
                    }

                    //The Swap check
                    comparisons++;

                    if (ascending)
                    {
                        if (r1 > r2)
                        {
                            sorted = false;
                            Customer temp = list[customer];
                            list[customer] = list[customer + 1];
                            list[customer + 1] = temp;
                            //Console.WriteLine($"comparison: {comparisons}, swap  {list[customer].Name} & {list[customer + 1].Name}");
                        }
                    }
                    else
                    {
                        if (r1 < r2)
                        {
                            sorted = false;
                            Customer temp = list[customer];
                            list[customer] = list[customer + 1];
                            list[customer + 1] = temp;
                            //Console.WriteLine($"comparison: {comparisons}, swap  {list[customer].Name} & {list[customer + 1].Name}");
                        }
                    }
                }
                //check if Array items are in order for early break.
                if (sorted == true)
                {
                    Console.WriteLine($"    Break Early. Iterations = {confirmed +1 } / max{list.Count - 1 } ");
                    break;
                }
            }
            Console.WriteLine($"    Bubble Sort comparisons: {comparisons}\n" +
                $"Print Array:");

        }

        //check 2 strings to rank alphabetically.
        static int[] Alphabetise(string check1, string check2)
        {
            int rank1 = 0; 
            int rank2 = 0;

            int charCheck = 0;

            while (rank1 == rank2 && charCheck < check1.Length && charCheck < check2.Length)
            {
                rank1 += check1[charCheck];
                rank2 += check2[charCheck];

                charCheck++;
            }

            int[] results = { rank1, rank2 };

            return results;
        }
    }
}
