using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LinearSearch
{
    class LinearSearch
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
            int result = linearSearch(arr, num);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result+1);

            Console.Read();
        }
        public static int linearSearch(int[] arr, int num)
        {
            int n;
            n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
