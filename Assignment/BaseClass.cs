using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BaseClass
    {
        //a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
        #region methods
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
        #endregion
    }
}
