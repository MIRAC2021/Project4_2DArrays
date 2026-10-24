using System;
using System.Diagnostics.Contracts;

namespace Project4_2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xAxis = 0;
            int yAxis = 0;

            Console.Write("Enter the number of rows in the array: ");
            xAxis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns in the array: ");
            yAxis = Convert.ToInt32(Console.ReadLine());

            int[,] Array2d = new int[xAxis,yAxis];

            for(int i = 0; i<xAxis; i++)
            {
                for (int j = 0; j < yAxis; j++)
                {
                    Console.Write("Enter integer value for the array at position [" + i + "," + j + "]: ");
                    Array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //for (int i = 0; i < xAxis; i++)
            //{
            //    Console.WriteLine("+---+");
            //    //Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            //    for (int j = 0; j < yAxis; j++)
            //    {
            //        //Console.WriteLine("+---+");
            //        Console.WriteLine("|   |");
            //        //Console.WriteLine("+---+");
            //    }
            //    Console.WriteLine("+---+");
            //}

            int yCounter = 0;

            while(yCounter < yAxis)
            {
                int counter1 = 0;
                while (counter1 < xAxis)
                {
                    Console.Write("+---+");
                    counter1++;
                }
                Console.WriteLine();
                int counter2 = 0;
                while (counter2 < xAxis)
                {
                    Console.Write("|   |");
                    counter2++;
                }
                Console.WriteLine();
                int counter3 = 0;
                while (counter3 < xAxis)
                {
                    Console.Write("+---+");
                    counter3++;
                }
                Console.WriteLine();

                yCounter++;
            }

            Console.WriteLine("The final array is: ");

            for (int i = 0; i < xAxis; i++)
            {
                for (int j = 0; j < yAxis; j++)
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

            //Console.Clear();
        }
    }
}
