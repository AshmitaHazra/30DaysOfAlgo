using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PositiveNegativeComp
{
    class PositiveNegativeComp
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, -2, 6, -7, 8 };
            int n = arr.Length;
            partitionNegPos(arr, n); 
        }
        static void partitionNegPos(int[] arr, int n)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();

            // Push first element to a.  
            a.Add(arr[0]);

            // Now put all elements of same sign 
            // in a[] and opposite sign in b[] 
            for (int i = 1; i < n; i++)
            {
                if (oppositeSigns(a[0], arr[i]))
                    b.Add(arr[i]);
                else
                    a.Add(arr[i]);
            }

            // Print a[] and b[] 
            for (int i = 0; i < a.Count; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("");
            for (int i = 0; i < b.Count; i++)
                Console.Write(b[i] + " ");
        }
        public static bool oppositeSigns(int x, int y)
        {
            return ((x ^ y) < 0);
        } 
    }
}
