using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two dimentional array size 3x3
            int[,] myArr = new int [3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
            //Calculate the sum of each row
            int row1 = myArr[0, 0] + myArr[0, 1] + myArr[0, 2];
            int row2 = myArr[1, 0] + myArr[1, 1] + myArr[1, 2];
            int row3 = myArr[2, 0] + myArr[2, 1] + myArr[2, 2];

            Console.WriteLine($"row1={row1}, row2={row2}, row3={row3}");
            //Calculate the avg of each column
            int cul1 = (myArr[0, 0] + myArr[1, 0] + myArr[2, 0])/ 3;
            int cul2 = (myArr[0, 1] + myArr[1, 1] + myArr[2, 1]) / 3;
            int cul3 = (myArr[0, 2] + myArr[1, 2] + myArr[2, 2]) / 3;

            Console.WriteLine($"row1={cul1}, row2={cul2}, row3={cul3}");

        }

        static int rowSum(int [][] array, int rowIndex)
        {
            return array[rowIndex][0] + array[rowIndex][1] + array[rowIndex][2];
        }
    }
}
