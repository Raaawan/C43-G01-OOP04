using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calculator
    {
        //Q1) Write a class named Calculator that contains a method named Add.Overload the Add method to:
        //●	Accept two integers and return their sum.
        //●	Accept three integers and return their sum.
        //●	Accept two doubles and return their sum.

        #region Methods
        public  int Add(int x, int y)
        {
            return x + y;
        }
        public  int Add(int x, int y,int z)
        {
            return x + y + z;
        }
        public  double Add(double x, double y)
        {
            return x + y;
        }

        #endregion

    }
}
