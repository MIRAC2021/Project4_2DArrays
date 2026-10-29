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

            if (xAxis < 0 || xAxis == 0)
            {
                Console.WriteLine("The number of rows must be a positive integer. Please enter a valid number: ");
                xAxis = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the number of columns in the array: ");
            yAxis = Convert.ToInt32(Console.ReadLine());

            if (yAxis < 0 || yAxis == 0)
            {
                Console.WriteLine("The number of columns must be a positive integer. Please enter a valid number: ");
                yAxis = Convert.ToInt32(Console.ReadLine());
            }

            int[,] Array2d = new int[xAxis, yAxis];

            for (int i = 0; i < xAxis; i++)
            {
                for (int j = 0; j < yAxis; j++)
                {
                    Console.Write("Enter integer value for the array at position [" + i + "," + j + "]: ");
                    Array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int maxValue = 0;
            foreach (int value in Array2d)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            //Console.WriteLine("Max value in the array is: " + maxValue);

            while (true)
            {
                Console.WriteLine("Please choose one of the modes to display the array: ");
                Console.WriteLine("1. Array displayed in a grid with borders");
                Console.WriteLine("2. Array displayed in reverse order with borders");
                Console.WriteLine("3. Array displayed in a grid without borders");
                Console.WriteLine("4. Array with values with colors");
                Console.Write("Please pick one of the options (1, 2, 3, or 4) or press 'ctrl + c' to exit: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                //Option 1: Array displayed in a grid with borders
                if (choice == 1)
                {
                    int yCounter = 0;

                    while (yCounter < yAxis)
                    {
                        int counter1 = 0;
                        while (counter1 < xAxis)
                        {
                            Console.Write("+");
                            int varValue = Array2d[counter1, yCounter].ToString().Length;
                            while (varValue > -1)
                            {
                                Console.Write("-");
                                varValue--;
                            }
                            Console.Write("+ ");
                            counter1++;
                        }
                        Console.WriteLine();
                        //
                        int counter2 = 0;
                        while (counter2 < xAxis)
                        {
                            Console.Write("| " + Array2d[counter2, yCounter] + "| ");
                            counter2++;
                        }
                        Console.WriteLine();
                        //
                        int counter3 = 0;
                        while (counter3 < xAxis)
                        {
                            Console.Write("+");
                            int varValue = Array2d[counter3, yCounter].ToString().Length;
                            while (varValue > -1)
                            {
                                Console.Write("-");
                                varValue--;
                            }
                            Console.Write("+ ");
                            counter3++;
                        }
                        Console.WriteLine();

                        yCounter++;
                    }
                }
                else if (choice == 2)
                {

                    //Option 2: Array displayed in reverse order with borders

                    for (int i = xAxis - 1; i >= 0; i--)
                    {
                        for (int j = yAxis - 1; j >= 0; j--)
                        {
                            Console.Write("+");
                            int varValue = Array2d[i, j].ToString().Length;
                            while (varValue > -1)
                            {
                                Console.Write("-");
                                varValue--;
                            }
                            Console.Write("+ ");
                        }
                        Console.WriteLine();
                        //
                        for (int j = yAxis - 1; j >= 0; j--)
                        {
                            Console.Write("| " + Array2d[i, j] + "| ");
                        }
                        Console.WriteLine();
                        //
                        for (int j = yAxis - 1; j >= 0; j--)
                        {
                            Console.Write("+");
                            int varValue = Array2d[i, j].ToString().Length;
                            while (varValue > -1)
                            {
                                Console.Write("-");
                                varValue--;
                            }
                            Console.Write("+ ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (choice == 3)
                {
                    //Option 3: Array displayed in a grid without borders
                    for (int i = 0; i < xAxis; i++)
                    {
                        for (int j = 0; j < yAxis; j++)
                        {
                            Console.Write(Array2d[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (choice == 4)
                {
                    //Option 4: Array with values with colors
                    for (int i = 0; i < xAxis; i++)
                    {
                        for (int j = 0; j < yAxis; j++)
                        {
                            if (Array2d[i, j] == maxValue)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(Array2d[i, j] + " ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(Array2d[i, j] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please run the program again and select a valid option.");
                }
            }  
        }
    }
}
