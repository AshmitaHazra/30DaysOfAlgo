using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairWithDifference
{
    class PairWithDifference
    {
        public static void Main(string[] args)
        {
            int[] arr = { 25, 30, 2, 80, 54, 82, 73, 5 };
            int difference = 23;
            pairDifference(arr, difference);
        }
        public static void pairDifference(int[] arr, int difference)
        {
            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        Console.WriteLine("The repeating pair is " + arr[i] + " and " + arr[j]);
                        flag = false;
                        break;
                    }

                }
            }
            if (flag)
                Console.WriteLine("Pair does not exists");
            Console.ReadLine();
        }
    }
}
