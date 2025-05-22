using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            double[] array = new double[10];
            //array[0] = 5;
            //array[1] = 17;
            //array[2] = 2;
            //array[3] = 6;
            //array[4] = 8;
            //array[5] = 9;
            //array[6] = 12;
            //array[7] = 7;
            //array[8] = 11;
            //array[9] = 14;
            for (int j = 0; j < array.Length; j++)
            {
                BubbleSort(array);
                for (int i = 0; i < 10; i++)
                {
                    array[i] = rnd.Next(1, 17);
                }
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.ForegroundColor = (ConsoleColor)(array[i]-1);
                    if ((array[i] - 1) <= 6)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (array[i] < 10)
                    {
                        Console.Write($"0{array[i]}|");
                    }
                    else
                    {
                        Console.Write($"{array[i]}|");
                    }
                }
                if (array[9] < 10)
                {
                    Console.ForegroundColor = (ConsoleColor)array[9];
                    if ((array[9] - 1) <= 6)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine($"0{array[9]}");
                }
                else
                {
                    Console.ForegroundColor = (ConsoleColor)(array[9]-1);
                    if ((array[9] - 1) <= 6)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(array[9]);
                }
            }
            Console.ReadKey();
        }
        static void BubbleSort(double[] arraytosort)
        {
            
            for(int j = 0 ; j < 10; j++)
            {
                double temp = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (arraytosort[i] > arraytosort[i + 1])
                    {
                        temp = arraytosort[i];
                        arraytosort[i] = arraytosort[i + 1];
                        arraytosort[i + 1] = temp;
                    }
                }
            }
        }
    }
}