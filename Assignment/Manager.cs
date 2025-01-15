using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Manager:Employee
    {
        public override void Work()
        {
            //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            //*Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.

            base.Work();
            Console.WriteLine("Manager is managing");

        }
    }
}
