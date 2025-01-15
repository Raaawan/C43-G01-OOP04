using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {

        //) Create a base class named Employee with method That Work as it prints    "Employee is  working".

        #region methods
        public virtual void Work()
        {
            Console.WriteLine("Employee is  working");
        }

        #endregion

    }
}
