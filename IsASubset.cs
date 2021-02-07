using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsASubset
{
    class IsASubset
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1 };

            int m = arr1.Length;
            int n = arr2.Length;

            if (isSubset(arr1, arr2, m, n))
                Console.WriteLine("arr2[] is subset of arr1[]");
            else
                Console.WriteLine("arr2[] is not a subset of arr1[]");
            Console.ReadLine();
        }
        public static bool isSubset(int[] arr1, int[] arr2, int m, int n)
        {
            int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                
                    if (arr1[i] == arr2[j])
                        break;

                    if (j == m)
                        return false;
               
            }
            return true;
        }
    }
}
