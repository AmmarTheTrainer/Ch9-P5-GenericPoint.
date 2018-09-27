using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_P5_GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Point using ints.
            ////Point<int> p = new Point<int>(10, 10);
            ////// Point using double.
            ////Point<double> p2 = new Point<double>(5.4, 3.3);

            //Console.WriteLine("***** Fun with Generic Structures *****\n");

            //// Point using ints.
            //Point<int> p = new Point<int>(10, 10);
            //Console.WriteLine("p.ToString()={0}", p.ToString());
            //p.ResetPoint();
            //Console.WriteLine("p.ToString()={0}", p.ToString());

            //Console.WriteLine();

            //// Point using double.
            //Point<double> p2 = new Point<double>(5.4, 3.3);
            //Console.WriteLine("p2.ToString()={0}", p2.ToString());
            //p2.ResetPoint();
            //Console.WriteLine("p2.ToString()={0}", p2.ToString());


            #region Constraning Type Parameters

            //MyGenericClass<int> myGeneric = new MyGenericClass<int>();
            //MyGenericClass<string> myGeneric2 = new MyGenericClass<string>();
            //MyGenericClass<Person> myGeneric2 = new MyGenericClass<Person>();
            //MyGenericClass<TestClass> myGeneric2 = new MyGenericClass<TestClass>();

            MyGenericClass<TestClass> mc = new MyGenericClass<TestClass>();


            #endregion

            Console.ReadLine();
        }
    }
}
