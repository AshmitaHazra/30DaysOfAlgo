using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FlatLandSpaceStation
{
    class FlatLandSpaceStation
    {
        static int flatlandSpaceStations(int n, int m, int[] c)
        {
            Array.Sort(c);
            int maxDistance = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                if (distance > maxDistance)
                    maxDistance = distance;
            }
            int lastSpaceStationDistance = n - 1 - c[m - 1];
            if (lastSpaceStationDistance > maxDistance)
            {
                maxDistance = lastSpaceStationDistance;
            }
            return maxDistance;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = flatlandSpaceStations(n, m, c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
