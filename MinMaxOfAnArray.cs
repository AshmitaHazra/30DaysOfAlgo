using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMaxOfAnArray
{
    class MinMaxOfAnArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1000, 11, 445, 1, 330, 3000 };
            int arr_size = 6;
            Pair minmax = getMinMax(arr, arr_size);
            Console.Write("Minimum element is {0}",minmax.min);
            Console.Write("\nMaximum element is {0}",minmax.max);
            Console.ReadLine();
        }
        public static Pair getMinMax(int[] arr, int size)
        {
            Pair minmax = new Pair();
            //for one element
            if (size == 1)
            {
                minmax.min = arr[0];
                minmax.max = arr[0];
            }
            //for more than one element
            if (arr[0] > arr[1])
            {
                minmax.min = arr[1];
                minmax.max = arr[0];
            }
            else
            {
                minmax.min = arr[0];
                minmax.max = arr[1];
            }
            for (int i = 2; i < size; i++)
            {
                if (arr[i] > minmax.max)
                    minmax.max = arr[i];
                else if (arr[i] < minmax.min)
                    minmax.min = arr[i];
            }
            return minmax;
        }
    }
    class Pair
    {
        public int min;
        public int max;
    }
}
