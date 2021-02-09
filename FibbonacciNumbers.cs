using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibbonacciNumbers
{
    class FibbonacciNumbers
    {
        //The Fibonacci sequence is a series of numbers where a number is the addition of the last two numbers, starting with 0, and 1
        public static void Main(string[] args)
        {
            int n = 9;
            int m = 8;
            Console.WriteLine(FibR(n));
            Console.WriteLine();
            Console.WriteLine(FibD(m));
            Console.WriteLine();
            Console.WriteLine(FibS(n));
            Console.Read();
        }
        //recursion
        public static int FibR(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibR(n - 1) + FibR(n - 2);
        }
        //Dynamic programming
        public static int FibD(int n)
        {
            int[] f= new int[n+2];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }
        //with space optimization 
        static int FibS(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0) return a;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        } 

    }
}
