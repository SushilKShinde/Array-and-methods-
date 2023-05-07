using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Array_and_Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose option from the below");
            Console.WriteLine("1.Array basics\n2.Print reverse array");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ArrayBasics.ArrayBasicInfo();
                    break;
                case 2:
                    ReverseArray.PrintReverseArray();
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }

        }  
    }
    
    
}
   
 