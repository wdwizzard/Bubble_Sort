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
            double[] array = new double[10];
            array[0] = 5;
            array[1] = 17;
            array[2] = 2;
            array[3] = 6;
            array[4] = 8;
            array[5] = 9;
            array[6] = 12;
            array[7] = 7;
            array[8] = 11;
            array[9] = 14;
            PrintArray(array);
            BubbleSort(array);
            PrintArray(array);
            Console.ReadKey();
        }
        static void PrintArray(double[] PrintArray)
        {
            for(int i = 0; i < PrintArray.GetLength(0) - 1; i++)
            {
                Console.Write($"{PrintArray[i]}|");
            }
            Console.WriteLine(PrintArray[PrintArray.GetLengt(0)-1]);
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
