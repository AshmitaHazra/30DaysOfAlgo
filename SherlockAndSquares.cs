using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SherlockAndSquares
{
    class SherlockAndSquares
    {
        static int squares(int a, int b)
        {
            int numOfSquares = 0;
            int x = 1;
            while (x * x < a) x++;
            while (x * x <= b)
            {
                numOfSquares++;
                x++;
            }
            return numOfSquares;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int q = Convert.ToInt32(Console.ReadLine());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(ab[0]);
                int b = Convert.ToInt32(ab[1]);
                int result = squares(a, b);
                textWriter.WriteLine(result);
            }
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
