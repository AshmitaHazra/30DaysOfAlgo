using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minAbsSumPair
{
    class MinAbsSumPair
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 60, -10, 70, -80, 85 };
            minAbsSumPair(arr, 6);
            Console.ReadLine();
        }
        public static void minAbsSumPair(int[] arr, int size)
        {
            if (size < 2)
                Console.WriteLine("Invalid Input");
            int sum_min = arr[0] + arr[1];
            int sum = 0;
            int minL = 0;
            int minR = 1;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    sum = arr[i] + arr[j];
                    if (Math.Abs(sum_min) > Math.Abs(sum))
                    {
                        sum_min = sum;
                        minL = i;
                        minR = j;
                    }
                }
            }
            Console.WriteLine(" The two elements whose sum is minimum are "+arr[minL] + " and " + arr[minR]);
        }
    }
}
