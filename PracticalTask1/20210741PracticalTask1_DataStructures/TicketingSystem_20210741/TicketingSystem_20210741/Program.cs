using System;
using System.Collections.Generic;
using System.Timers;

namespace TicketingSystem_20210741
{
    class Program
    {
        private static System.Timers.Timer timerCustomer;

        public static Queue<Customer> customersQueue = new Queue<Customer>();

        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning Ticketing System!");

            SetTimerCustomer();

            SalesAssistant phil = new SalesAssistant(5000);

            //Exit App
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.ReadLine();
            timerCustomer.Stop();
            timerCustomer.Dispose();
        }
        //Create a timer for Customers.
        private static void SetTimerCustomer()
        {
            timerCustomer = new System.Timers.Timer(3000);
            timerCustomer.Elapsed += TimerCustomer_Elapsed;
            timerCustomer.AutoReset = true;
            timerCustomer.Start();
        }

        private static void TimerCustomer_Elapsed(object sender, ElapsedEventArgs e)
        {
            customersQueue.Enqueue(new Customer());
        }

        public static void ListQueue()
        {
            int count = 0;
            Console.Write($"The customers with the following tickets are in the queue: ");
        
            foreach(Customer c in customersQueue)
            {
                Console.Write(customersQueue);
            }
        }
    }
}
