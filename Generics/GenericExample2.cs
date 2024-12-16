//using System;

//namespace Generics
//{
//    internal class GenericExample2
//    {
//        public void Meth()
//        {
//            Console.WriteLine("Printing integer values:");
//            int[] a = { 1, 2, 3, 4, 5 };
//            GenericExample2.ToPrint(a);

//            Console.WriteLine("Printing float values:");
//            double[] b = { 2.1, 9.9, 9.0 };
//            GenericExample2.ToPrint(b);

//            Console.WriteLine("Printing string values:");
//            string[] c = { "a", "b", "c" };
//            GenericExample2.ToPrint(c);
//        }

//        // Generic method to print array elements
//        public static void ToPrint<T>(T[] arr)
//        {
//            foreach (T item in arr)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            GenericExample2 example = new GenericExample2();
//            example.Meth(); // No need for generic type argument here
//        }
//    }
//}
