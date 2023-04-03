using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal class Customer : ICustomer, IComparable
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Number { get; }

        public Customer(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public int CompareTo(ICustomer other)
        {
            string fullName = FirstName + " " + LastName;
            string otherFullName = other.FirstName + " " + other.LastName;
            return fullName.CompareTo(otherFullName);
        }

        public int CompareByNumber(ICustomer other)
        {
            return Number.CompareTo(other.Number);
        }

        public int CompareTo(object? obj)
        {
            ICustomer otherCustomer = obj as ICustomer;
            return this.CompareTo(otherCustomer);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Number}\n";
        }
    }
}
