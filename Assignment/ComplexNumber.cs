using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class ComplexNumber
    {
        //Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
        //* Note: Overload the +, - operator to add and subtract two complex numbers.

        #region properties
        public int Real {  get; set; }
        public int Imgine { get; set; }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"{Real}+{Imgine}i";
        }

        #region operator overloading
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imgine = (a?.Imgine ?? 0) + (b?.Imgine ?? 0),

            };
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imgine = (a?.Imgine ?? 0) - (b?.Imgine ?? 0),

            };
        }
        #endregion
        #endregion
    }
}
