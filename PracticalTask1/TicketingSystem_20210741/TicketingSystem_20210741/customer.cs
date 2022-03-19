using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem_20210741
{
    class Customer
    {
        static int ticketCount = 0;
        public int TicketNumber;

        //Create Customer with Ticketnumber
        public Customer()
        {
            ticketCount++;

            TicketNumber = ticketCount;

            Console.WriteLine($" Customer with ticket {this.TicketNumber} is added to the queue.");

        }
    }
}
