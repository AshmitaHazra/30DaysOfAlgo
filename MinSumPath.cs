using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinSumPath
{
    class MinSumPath
    {
        public static void Main(string[] args)
        {
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int> { 2 });
            A.Add(new List<int> { 3, 9 });
            A.Add(new List<int> { 1, 6, 7 });
            Console.WriteLine(minSumPath(ref A)); 
        }
        public static int minSumPath(ref List<List<int>> A)
        {
            int[] memo = new int[A.Count];
            int n = A.Count - 1;

            for (int i = 0; i < A[n].Count; i++)
                memo[i] = A[n][i];

            // Calculation of the remaining rows, 
            // in bottom up manner. 
            for (int i = A.Count - 2; i >= 0; i--)
                for (int j = 0; j < A[i + 1].Count - 1; j++)
                    memo[j] = A[i][j] +
                              (int)Math.Min(memo[j],
                                       memo[j + 1]);

            // return the top element 
            return memo[0]; 
        }
    }
}
