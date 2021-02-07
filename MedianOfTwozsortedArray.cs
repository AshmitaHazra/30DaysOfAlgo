using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedianOfTwozsortedArray
{
    class MedianOfTwozsortedArray
    {
        public static void Main(string[] args)
        {
            int[] ar1 = { 1, 12, 15, 26, 38 };
            int[] ar2 = { 2, 13, 17, 30, 45 };

            int n1 = ar1.Length;
            int n2 = ar2.Length;
            if (n1 == n2)
                Console.Write("Median is " +
                            getMedian(ar1, ar2, n1));
            else
                Console.Write("arrays are of unequal size");
            Console.Read();
    
        }
        public static int getMedian(int[] arr1, int[] arr2, int n)
        {
            int i=0;
            int j=0;
            int count;
            int m1 = -1, m2 = -1;

            for(count = 0; count <= n; count++)
            {
                if (i == n)
                {
                    m2 = m1;
                    m1 = arr1[0];
                    break;
                }
                else if (j == n)
                {
                    m1 = m2;
                    m2 = arr2[0];
                    break;
                }
                if (arr1[i] <= arr2[j])
                {
                    m1 = arr1[i];
                    i++;
                }
                else
                {
                    m2 = arr2[j];
                    j++;
                }

            }
            return (m1 + m2) / 2; 

        }
    }
}