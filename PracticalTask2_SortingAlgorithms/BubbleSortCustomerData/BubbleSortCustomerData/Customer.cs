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
    }
}
