﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DerivedClass2:BaseClass
    {
        //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
        #region methods
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
        #endregion
    }
}
