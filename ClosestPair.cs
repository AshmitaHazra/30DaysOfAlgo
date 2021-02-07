using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosestPair
{
    class ClosestPair
    {
        public static void Main(string[] args)
        {
            int[] ar1 = { 1, 4, 5, 7 };
            int[] ar2 = { 10, 20, 30, 40 };
            int m = ar1.Length;
            int n = ar2.Length;
            int x = 38;

            printClosest(ar1, ar2, m, n, x);
            Console.ReadLine();
        }
        public static void printClosest(int[] arr1, int[] arr2, int s1, int s2, int find)
        {
            int diff = int.MaxValue;
            int R1 = 0, R2 = 0;
            int i = 0, j = s2 - 1;

            while (i < s1 && j >= 0)
            {
                //checking if the resultant pair is less than the saved difference
                if (Math.Abs(arr1[i] + arr2[j] - find) < diff)
                {
                    R1 = i;
                    R2 = j;
                    diff = Math.Abs(arr1[i] + arr2[j] - find);
                }
                //if the pair is greater than the desired sum shift the 2nd array else the 1st one
                if (arr1[i] + arr2[j] > find)
                    j--;
                else
                    i++;
            }
            Console.Write("The closest pair is ["+ arr1[R1] + ", "+ arr2[R2] + "]");
        }
    }
}
