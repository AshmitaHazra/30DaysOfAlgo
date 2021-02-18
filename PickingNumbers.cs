using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PickingNumbers
{
    class PickingNumbers
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int n = a.Count;
            int cnt = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (a[j] - a[i] <= 1)
                    {
                        cnt++;
                    }
                }
                if (cnt > max)
                    max = cnt;
                cnt = 0;
            }
            return max;

        }

    }
}
