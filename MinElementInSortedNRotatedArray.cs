using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinElementInSortedNRotatedArray
{
    class MinElementInSortedNRotatedArray
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 5, 6, 1, 2, 3, 4 };
            int n1 = arr1.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr1, 0, n1 - 1));

            int[] arr2 = { 1, 2, 3, 4 };
            int n2 = arr2.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr2, 0, n2 - 1));

            int[] arr3 = { 1 };
            int n3 = arr3.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr3, 0, n3 - 1));

            int[] arr4 = { 1, 2 };
            int n4 = arr4.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr4, 0, n4 - 1));

            int[] arr5 = { 2, 1 };
            int n5 = arr5.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr5, 0, n5 - 1));

            int[] arr6 = { 5, 6, 7, 1, 2, 3, 4 };
            int n6 = arr6.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr6, 0, n6 - 1));

            int[] arr7 = { 1, 2, 3, 4, 5, 6, 7 };
            int n7 = arr7.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr7, 0, n7 - 1));

            int[] arr8 = { 2, 3, 4, 5, 6, 7, 8, 1 };
            int n8 = arr8.Length;
            Console.WriteLine("The minimum element is " +
                               findMin(arr8, 0, n8 - 1));

            int[] arr9 = { 3, 4, 5, 1, 2 };
            int n9 = arr9.Length;
            Console.WriteLine("The minimum element is " +findMin(arr9, 0, n9 - 1));
            Console.ReadLine();
        }
        public static int findMin(int[] arr, int initial, int final)
        {
            while (initial < final)
            {
                int mid = initial + (final - initial) / 2;
                if (arr[mid] == arr[final])
                    final--;
                else if(arr[mid] > arr[final])
                    initial = mid +1;
                else
                    final = mid;
            }
            return arr[final];
        }
    }
}
