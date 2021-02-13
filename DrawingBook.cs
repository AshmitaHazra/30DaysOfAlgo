using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DrawingBook
{
    class DrawingBook
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        static int pageCount(int n, int p)
        {
            int turnFront, turnBack;
            if (p % 2 == 1)
                turnFront = (p - 1) / 2;
            else
                turnFront = p / 2;

            if (n % 2 == 1)
                turnBack = (n - p) / 2;
            else
            {
                n = n + 1;
                turnBack = (n - p) / 2;
            }
            return min(turnFront, turnBack);
        }
        public static int min(int x, int y)
        {
            if (x > y)
                return y;
            else
                return x;
        }
    
    }
}
