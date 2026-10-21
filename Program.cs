using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project4_2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.Write("Enter the number of rows in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns in the array: ");
            y = Convert.ToInt32(Console.ReadLine());

            int[,] Array2d = new int[x,y];

            for(int i = 0; i<x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("Enter integer value for the array at position [" + i + "," + j + "]: ");
                    Array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The final array is: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Console.WriteLine();
                    int varValue = Array2d[i, j].ToString().Length;
                    while (varValue > -1)
                    {
                        Console.Write("--");
                        varValue--;
                    }
                    Console.WriteLine();
                    Console.Write("| " + Array2d[i, j] + " |");
                    Console.WriteLine();
                    int newVarValue = Array2d[i, j].ToString().Length;
                    while (newVarValue > -1)
                    {
                        Console.Write("--");
                        newVarValue--;
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
