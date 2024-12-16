using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class BiggestUsingComparable
    {
        public static T FindBiggest<T>(T val1,T val2,T val3) where T:IComparable<T>
        {
            if (val1.CompareTo(val2) > 0 && val2.CompareTo(val3) > 0)
                return val1;

            else if (val2.CompareTo(val3) > 0 && val2.CompareTo(val1) > 0)
            {
                return val2;
            }
            else
                return val3;
        }
        
    }
}
