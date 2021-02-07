using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Insertionsort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 64, 75, 15, 25, 12, 22, 11 };
            insertionSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
            Console.ReadLine();
        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = key;
            }
        }
    }
}
