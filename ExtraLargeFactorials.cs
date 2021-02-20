using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ExtraLargeFactorials
{
    class ExtraLargeFactorials
    {
        static void extraLongFactorials(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            extraLongFactorials(n);
        }
    }
}
