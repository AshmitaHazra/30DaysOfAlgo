using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BellNumbers
{
    class BellNumbers
    {
        //Number of ways to Partition a Set
        public static void Main(string[] args)
        {
            for (int n = 0; n <= 5; n++)
                Console.WriteLine("Bell Number "+ n +" is "+ bellNumber(n));
            Console.ReadLine();
        }
        public static int bellNumber(int n)
        {
            int[,] bell = new int[n + 1, n + 1];
            bell[0, 0] = 1;
            for (int i = 1; i <= n; i++)
            {
                bell[i, 0] = bell[i - 1, i - 1];
                for (int j = 1; j <= i; j++)
                {
                     bell[i, j] = bell[i - 1, j - 1] + bell[i, j - 1]; 
                }
            }
            return bell[n, 0];
        }
    }
}
