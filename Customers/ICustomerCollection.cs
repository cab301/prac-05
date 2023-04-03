using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal interface ICustomerCollection
    {
        int Capacity { get; }
        int Count { get; }

        string Find(string firstName, string lastName);

        void Insert(string firstName, string lastName, string number);

        void Insert(ICustomer customer);
        /// <summary>
        /// Given the first name and last name of a customer, this method removes the customer out of the data structure.
        /// 
        /// Pre: The collection is not empty
        /// 
        /// Post: The given customer is removed
        /// 
        /// </summary>
        /// <param name="firstName">The first name of the customer</param>
        /// <param name="lastName">The last name of the customer</param>
        void Delete(string firstName, string lastName);
        /// <summary>
        /// This method displays the information about all the customers in the data structure.
        /// </summary>
        void Display();

        void Sort();
    }
}
