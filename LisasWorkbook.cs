using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Lisa_sWorkbook
{
    class Program
    {
        static int workbook(int n, int k, int[] arr)
        {
            int result = 0;
            int page = 1;
            // chapter
            for (int i = 0; i < arr.Length; i++)
            {
                int problems = arr[i];

                // problems
                for (int problem = 1; problem <= problems; problem++)
                {
                    if (problem == page)
                    {
                        result++;
                    }
                    if ((problem % k == 0) || problem == problems)
                    {
                        page++;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = workbook(n, k, arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
