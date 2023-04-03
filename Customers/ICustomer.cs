using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal interface ICustomer
    {
        string FirstName { get; }
        string LastName { get; }
        string Number { get; }

        /// <summary>
        /// Return a positive number if this cusomter comes after the
        /// other customer. If the two customers are the same, return 0,
        /// otherwise return -1
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int CompareTo(ICustomer other);

        int CompareByNumber(ICustomer other);
    }
}
