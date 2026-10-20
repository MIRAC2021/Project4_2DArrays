using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Enter the number of rows in thearray: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns in the array: ");
            y = Convert.ToInt32(Console.ReadLine());

            int[,] Array2d = new int[x,y];

            for(int i = 0; i<x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter the value for the array at position [" + i + "," + j + "]: ");
                    Array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The final array is: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(Array2d[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
