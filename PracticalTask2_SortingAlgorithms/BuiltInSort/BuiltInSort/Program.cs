using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BuiltInSort

{
    class BuiltInSort
    {
        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                "Id: " + arr[i].Id + ", "
                + "Name: " + arr[i].ItemName + ", "
                + "Category: " + arr[i].Category);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BuiltInSort ob = new BuiltInSort();
            CatalogueItem[] arr = {
new CatalogueItem( 3, "Life of Pi","Books"),
new CatalogueItem( 7, "Deelongie 4 way toaster","Home and Kitchen"),
new CatalogueItem( 2, "Glorbarl knife set","Home and Kitchen"),
new CatalogueItem( 4, "Diesorn vacuum cleaner","Appliances"),
new CatalogueItem( 5, "Jennie Olivier sauce pan","Home and Kitchen"),
new CatalogueItem( 6, "This book will save your life","Books"),
new CatalogueItem( 9, "Kemwould hand mixer","Appliances"),
new CatalogueItem( 1, "Java for Dummies","Books"),
};
            Console.WriteLine("The Unsorted array is\r\n");
            ob.PrintArray(arr);
            //apply sort

            //Start a Timer
            System.Diagnostics.Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();
            
            //sort
            arr = arr.OrderBy(c => c.Category).ToArray();
            
            timer.Stop();

            double timeTaken = timer.ElapsedTicks;
            string ticksTaken = timer.ElapsedTicks.ToString();

            Console.WriteLine($"**Array sorted by Category:\n" +
                                $"  elapsed ticks(10,000 per millisecond): {ticksTaken}\n");

            Console.WriteLine("The array sorted by category using C# built in sort is:\r\n");
            ob.PrintArray(arr);
            Console.Read();
        }
    }


    class CatalogueItem
    {
        public Int32 Id { get; set; }
        public String ItemName { get; set; }
        public String Category { get; set; }
        // constructor
        public CatalogueItem(Int32 newId, String newName, String
        newCategory)
        {
            Id = newId;
            ItemName = newName;
            Category = newCategory;
        }
    }
}   