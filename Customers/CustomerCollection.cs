using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal class CustomerCollection : ICustomerCollection
    {
        private ICustomer[] customers;
        private int capacity;
        private int count;

        public CustomerCollection(int capacity)
        {
            customers = new ICustomer[capacity];
            this.capacity = capacity;
            count = 0;
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Delete(string firstName, string lastName)
        {
            // If empty, don't do anything
            if (count == 0) return;
            // Try to find the customer
            int indexToDelete = -1;
            for (int i = 0; i < count; i++)
            {
                if (customers[i].LastName == lastName
                    && customers[i].FirstName == firstName)
                {
                    indexToDelete = i;
                    break; // Find the first matching customer
                }
            }
            // If not found, don't do anything
            if (indexToDelete == -1) return;

            // Do the deletion (overwrite the customer we try to delete)
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
                Console.WriteLine("{0} \t\t {1} \t\t {2}",
                    customers[i].FirstName,
                    customers[i].LastName,
                    customers[i].Number);
            }
            Console.WriteLine("{0} customers found", count);
        }

        public string Find(string firstName, string lastName)
        {
            foreach (ICustomer customer in customers)
            {
                if (customer.FirstName == firstName 
                    && customer.LastName == lastName)
                {
                    return customer.Number;
                }
            }
            return "Not found";
        }

        public void Insert(string firstName, string lastName, string number)
        {
            Insert(new Customer(firstName, lastName, number));
        }

        public void Insert(ICustomer customer)
        {
            // Don't do anything if collection is full
            if (count == capacity) return;
            customers[count] = customer;
            count++;
        }

        public void Sort()
        {
            InsertionSort(customers);
        }

        private void InsertionSort(ICustomer[] array)
        {
            for (int i = 1; i <= array.Length - 1; i++)
            {
                ICustomer v = array[i];
                int j = i - 1;
                while (j >= 0 &&
                    array[j].CompareTo(v) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = v;
            }
        }
    }
}
