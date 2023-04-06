using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class CustomerCollection
    {
        private Customer[] customers;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public CustomerCollection(int capacity)
        {
            this.capacity = capacity;
            customers = new Customer[capacity];
            count = 0;
        }

        // Given first and last name, find
        // phone number
        public string Find(string firstName, string lastName)
        {
            foreach (Customer customer in customers)
            {
                if (customer.FirstName == firstName
                    && customer.LastName == lastName)
                {
                    return customer.Number;
                }
            }
            return "Not found";
        }

        public void Insert(string firstName, 
            string lastName, 
            string number)
        {
            Insert(new Customer(firstName, lastName, number));
        }

        public void Insert(Customer customer)
        {
            // Don't insert if full
            if (capacity == count) return;

            customers[count] = customer;
            count++;
        }

        public void Delete(string firstName, 
            string lastName)
        {
            // Don't delete if empty
            if (count == 0) return;

            // try to find the index to delete
            int indexToDelete = -1;
            for (int i = 0; i < count; i++)
            {
                if (customers[i].LastName == lastName
                    && customers[i].FirstName == firstName)
                {
                    indexToDelete = i;
                    break;
                }
            }

            // Don't delete if not found
            if (indexToDelete == -1) return;

            // Shift everything from the right to the left
            // to overwrite this customer
            for (int i = indexToDelete; i < count - 1; i++)
            {
                customers[i] = customers[i + 1];
            }
            count--;
        }

        public void Display()
        {
            Console.WriteLine("First Name \t Last Name \t Number");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t",
                    customers[i].FirstName, customers[i].LastName,
                    customers[i].Number);
            }
            Console.WriteLine("{0} customers found", count);
        }

        public void Sort()
        {
            for (int i = 0; i <= count - 2; i++)
            {
                int min = i;
                for (int j = i + 1; j <= count - 1; j++)
                {
                    // Check if customer j should come
                    // before customer min => -1 or negative
                    if (customers[j].CompareTo(customers[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(ref customers[i], ref customers[min]);
            }
        }

        public void Swap(ref Customer a, ref Customer b)
        {
            Customer temp = a;
            a = b;
            b = temp;
        }
    }
}
