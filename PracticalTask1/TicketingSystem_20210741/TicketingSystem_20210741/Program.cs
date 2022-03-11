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
            Console.WriteLine("Good Morning Ticketing System!\n");

            SalesAssistant salesAssistant = new SalesAssistant(5000);
            salesAssistant.SeeCustomer();

            SetTimerCustomer(3000);

            //Exit App
            Console.WriteLine("\n***Press Enter to Stop Customers arriving***\n");
            Console.ReadLine();
            timerCustomer.Stop();
            timerCustomer.Dispose();

            Console.WriteLine($"\n***press 'c' to add a customer to queue. Any key to Exit****");
            
            char createCustomer = 'c';

            createCustomer = Console.ReadKey().KeyChar;

            while (createCustomer == 'c')
            {
                customersQueue.Enqueue(new Customer());
                createCustomer = Console.ReadKey().KeyChar;
            }
            
            Console.ReadLine();

            salesAssistant.timerSalesAssistant.Stop();
            salesAssistant.timerSalesAssistant.Dispose();
        }
        //Create a timer for Customers.
        private static void SetTimerCustomer(int time)
        {
            timerCustomer = new System.Timers.Timer(time);
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
            int count = customersQueue.Count;

            if (count > 0)
            {
                Console.Write($"The customers with the following tickets are in the queue: [");

                foreach (Customer c in customersQueue)
                {
                    if (count > 1)
                    {
                        Console.Write($"{c.TicketNumber}, ");
                        count--;
                    }
                    else
                    {
                        Console.Write($"{c.TicketNumber}]");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("there are no customers in the queue");
            }
        }
    }
}
