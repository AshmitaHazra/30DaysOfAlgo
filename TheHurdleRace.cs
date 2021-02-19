using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TheHurdleRace
{
    class TheHurdleRace
    {
        static int hurdleRace(int k, int[] height)
        {

            int max = int.MinValue;
            for (int i = 0; i < height.Length; i++)
            {
                if (max < height[i])
                    max = height[i];
            }
            int result = max - k;
            if (k > max)
                return 0;
            else
                return result;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
