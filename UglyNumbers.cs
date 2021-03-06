﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UglyNumbers
{
    class UglyNumbers
    {
        public static void Main(string[] args)
        {
            int n = 150;
            Console.WriteLine(getNthUglyNo(n));
            Console.Read();
        }
        //Ugly numbers are those number whose prime factors are 2, 3 or 5
        public static int getNthUglyNo(int n)
        {
            int[] ugly = new int[n];
            int i2 = 0, i3 = 0, i5 = 0;
            int next_multiple_of_2 = 2;
            int next_multiple_of_3 = 3;
            int next_multiple_of_5 = 5;
            int next_ugly_no = 1;

            ugly[0] = 1;
            for (int i = 1; i < n; i++)
            {
                next_ugly_no = Math.Min(next_multiple_of_2, Math.Min(next_multiple_of_3, next_multiple_of_5));
                ugly[i] = next_ugly_no;

                if (next_ugly_no == next_multiple_of_2)
                {
                    i2 = i2 + 1;
                    next_multiple_of_2 = ugly[i2] * 2;
                }
                if (next_ugly_no == next_multiple_of_3)
                {
                    i3 = i3 + 1;
                    next_multiple_of_3 = ugly[i3] * 3;
                }
                if (next_ugly_no == next_multiple_of_5)
                {
                    i5 = i5 + 1;
                    next_multiple_of_5 = ugly[i5] * 5;
                }
            }
            return next_ugly_no;
        }
    }
}
