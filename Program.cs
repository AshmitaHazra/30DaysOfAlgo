using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Please enter the size:");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Please enter the numbers:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int num;
            Console.WriteLine("Please enter the number to be searched:");
            num = int.Parse(Console.ReadLine()); 
            int result = binarySearch(arr, num);

            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
            {
                result = result + 1;
                Console.WriteLine("Element is present at index " + result);
            }

            Console.Read();
        }
        public static int binarySearch(int[] arr, int num)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (arr[m] == num)
                    return m;

                // If x greater, ignore left half 
                if (arr[m] < num)
                    l = m + 1;

                // If x is smaller, ignore right half 
                else
                    r = m - 1;
            }

            // if we reach here, then element was 
            // not present 
            return -1; 
        }

    }
}
