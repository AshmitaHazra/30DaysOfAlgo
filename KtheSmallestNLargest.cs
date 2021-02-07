using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KtheSmallestNLargest
{
    class KtheSmallestNLargest
    {
        public static void Main(string[] args)
        {
            int[] ar = { 1, 56, 4, 63, 5, 7, 90, 10, 3, 20, 6, 30, 40 };
            int size = ar.Length;
            int k = 5;
            KthLargest(ar, size, k);
            KthSmallest(ar, size, k);
            Console.ReadLine();
        }
        public static void KthLargest(int[] arr1, int size, int k)
        {
            Array.Sort(arr1);
            Console.WriteLine("Kth Largest number is : "+arr1[size-k-1]);
        }
        public static void KthSmallest(int[] arr1, int size, int k)
        {
            Array.Sort(arr1);
            Console.WriteLine("Kth Smallest number is : " + arr1[k - 1]);
        }
    }
}
