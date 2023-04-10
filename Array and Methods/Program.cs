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
            Console.WriteLine("Hello world");

            //2D array 
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            //foreach loop
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            //for loop
            for (int i=0; i<numbers.GetLength(0); i++)
            {
                for(int j=0; j<numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
