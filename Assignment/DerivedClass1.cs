using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DerivedClass1:BaseClass
    {
        //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
        #region method
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
        #endregion
    }
}
