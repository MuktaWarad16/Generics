using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Generics
{
    internal class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine( BiggestUsingComparable.FindBiggest(10,20,30));
        }
    }
}
