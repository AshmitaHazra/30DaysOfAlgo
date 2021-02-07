using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class SelectionSort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            selectionSort(arr);
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
        public static void selectionSort(int[] arr)
        {
            int size = arr.Length;
            //after every iteration staring from the begining 1 elememt gets its place
            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    int min =i;
                    if (arr[j] < arr[min])
                        min = j;
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }

        }
    }
}