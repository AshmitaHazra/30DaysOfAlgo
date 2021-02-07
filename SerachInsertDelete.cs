using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerachInsertDelete
{
    class SerachInsertDelete
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 12, 34, 10, 6, 40 };
            int n = arr1.Length;

            // Using a last element as  
            // search element 
            int key1 = 40;
            int position = findElement(arr1, n, key1);

            if (position == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element Found at Position: "
                                    + (position + 1));

            //searching
            int[] arr = new int[20];
            arr[0] = 12;
            arr[1] = 16;
            arr[2] = 20;
            arr[3] = 40;
            arr[4] = 50;
            arr[5] = 70;
            int capacity = 20;
            int size = 6;
            int i, key = 26;

            Console.Write("Before Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // Inserting key 
            size = insertSorted(arr, size, key, capacity);

            Console.Write("After Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            //deleting
            int i2;
            int[] arr2 = { 10, 50, 30, 40, 20 };

            int n2 = arr.Length;
            int key2 = 30;

            Console.Write("Array before deletion ");
            for (i2 = 0; i2 < n; i2++)
                Console.Write(arr[i2] + " ");
            Console.WriteLine();

            n2 = deleteElement(arr2, n2, key2);

            Console.Write("Array after deletion ");
            for (i2 = 0; i < n2; i2++)
                Console.Write(arr[i2] + " ");

            Console.ReadLine();
        }

        public static int findElement(int[] arr, int n, int key)
        {
            for (int i = 0; i < n; i++)
                if (arr[i] == key)
                    return i;
            return -1;
        }
        public static int insertSorted(int[] arr, int n, int key, int capacity)
        {
            if (n >= capacity)
                return n;
            arr[n] = key;
            return (n + 1);
        }
        public static int deleteElement(int[] arr, int n, int key)
        {
            int pos = findElement(arr, n, key);
            if (pos == -1)
            {
                Console.WriteLine("Element not found");
                return n;
            }
            // Deleting element 
            int i;
            for (i = pos; i < n - 1; i++)
                arr[i] = arr[i + 1];
            return n - 1;
        }
    }
}
