using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace TicketingSystem_20210741
{
    public class SalesAssistant
    {
        Timer timerSalesAssistant;

        Queue<Customer> customerQueue;

        public SalesAssistant(int time)
        {
            customerQueue = Program.customersQueue;

            timerSalesAssistant = new System.Timers.Timer(time);
            timerSalesAssistant.Elapsed += SeeCustomer;
            timerSalesAssistant.AutoReset = true;
            timerSalesAssistant.Start();
        }
        public void SeeCustomer(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("\nSales Assistant is ready to see the next customer.");

            if (customerQueue.Count > 1)
            {
                Customer customer = customerQueue.Dequeue();

                Console.WriteLine($"The customer with ticket number {customer.TicketNumber} will be seen");

                Program.ListQueue();
            }
            else if (customerQueue.Count == 1)
            {
                Customer customer = customerQueue.Dequeue();

                Console.WriteLine($"The last customer with ticket number {customer.TicketNumber} will be seen.");

            }
            else
            {
                Console.WriteLine("There is no customer in the queue.");
            }
        }
    }
}
