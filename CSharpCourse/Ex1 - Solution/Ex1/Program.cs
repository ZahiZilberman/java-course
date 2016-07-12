using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {

        /// <summary>
        /// Exercize: Arrays
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Create a new array
            int[] myArr = { 1, 2, 3, 4, 5 };
            //Print the sum of index 0,4
            int sumOfIndex = myArr[0] + myArr[4];
            Console.WriteLine("Sum of indices 0, 4 is: " + sumOfIndex);
            
            //one line solution:
            //Console.WriteLine("Sum of indices 0, 4 is: " + (myArr[0] + myArr[4]));
            //Calling the method from below
            //Console.WriteLine("Sum of indices 0, 4 is: " + sum(myArr));


            //Print the avg of index 1,2,3
            double avgOfIndex = (myArr[1] + myArr[2] + myArr[3]) / 3;
            Console.WriteLine("Sum of indices 0, 4 is: " + avgOfIndex);

            //one line solution:
            //Console.WriteLine("Sum of indices 0, 4 is: " + ((myArr[1] + myArr[2] + myArr[3]) / 3));
            //Calling the method from below
            //Console.WriteLine("Sum of indices 0, 4 is: " + avg(myArr));
        }

        //Calculate the sum of index 0,4
        static int sum(int[] array)
        {
            return array[0] + array[4];
        }

        //Calculate the sum of index 0,4
        static double avg(int[] array)
        {
            return (array[1] + array[2] + array[3]) / 3;
        }
    }
}
