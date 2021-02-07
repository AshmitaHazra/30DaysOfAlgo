using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Occurance
{
    class Occurance
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2, 2, 3, 4, 7, 8, 8, 2, 2 };
            int n = arr.Length;
            int x = 2;

            Console.Write(countOccurrences(arr, n, x));
            Console.ReadLine();
        }
        public static int countOccurrences(int[] arr, int size, int num)
        {
            int result =0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == num)
                    result++;
            }
            return result;
        }
    }
}
