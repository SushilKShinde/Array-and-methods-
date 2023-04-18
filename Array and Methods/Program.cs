using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Methods
{
    internal class Program
    {
        //method with single parameter
        static void MyMethod1(int x)
        {
            Console.WriteLine(x+5);
        }
        //method with multiple parameter
        static void MyMethod2(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        //method returning result
        static int MyMethod3(int x, int y)
        {
            return x + y;
        }
        //method with default parameters
        static void MyMethod4(string country="India")
        {
            Console.WriteLine(country);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            // method is a block of code which can be reused and it can be called by its name
            // methods are also called as Functions 
           
            MyMethod1(8);
            MyMethod2(5, 4);
            int result = MyMethod3(5, 6);
            Console.WriteLine(result);
            MyMethod4("Japan");
            MyMethod4();

           

        }
    }
}
