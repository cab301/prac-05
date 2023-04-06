using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Customer : IComparable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Number { get; }

        public Customer(string firstName, 
            string lastName, 
            string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public int CompareByNumber(Customer other)
        {
            return Number.CompareTo(other.Number);
        }

        /// <summary>
        /// Use the fullname as a string representation of the customer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName + ",";
        }

        public int CompareTo(object? obj)
        {
            Customer other = obj as Customer;
            string fullName = FirstName + " " + LastName;
            string otherFullName = other.FirstName + " " + other.LastName;
            return fullName.CompareTo(otherFullName);
        }
    }
}
