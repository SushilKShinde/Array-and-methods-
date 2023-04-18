using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Methods
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Array is the collection of similar data items stored in the contigious memory
            //array can be accessed with the index number

            //syntax for declaring an array
            // datatype[] arrayName = new datatype[SizeOfArray]
            int[] myArray1 = new int[4];                 // first way to declare an array 
            int[] myArray2 = new int[] { 10, 20, 30 };   // second way to declare an array
            int[] myArray3 = { 01, 02, 03 };             // third way to declare an array
            //storing values in array
            myArray1[0] = 10;
            myArray1[1] = 20;
            myArray1[2] = 30;
            myArray1[3] = 40;
            //accessing array values
            // Console.WriteLine(myArray1[3]);          // o/p >> 40

            //Console.WriteLine(myArray2.Length);      // size of array

            //printing array elements
            ///foreach (int element in myArray1)
            //{
            //  Console.WriteLine(element);
            // }

            // MultiDimensional array
                                  //[row,column]
            int[,] myArray4 = new int[3, 4]
            {
              //clm0  clm1 clm2  clm3
                {10,  20,  30,   40 }, // row 0
                {40,  50,  60,   70 }, // row 1
                {70,  80,  90,   100 } //row 2
            };
            // Multidimensional arrays can be accessed by row and colomn numbers
            Console.WriteLine(myArray4[2,3]);
        }
    }
}
