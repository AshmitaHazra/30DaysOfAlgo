using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BeautifulDaysAtTheMovies
{
    class BeautifulDaysAtTheMovies
    {
        static int beautifulDays(int i, int j, int k)
        {
            int numOfBeautifulDays = 0;
            for (int l = i; l <= j; l++)
            {
                if ((l - reverse(l)) % k == 0)
                    numOfBeautifulDays++;
            }
            return numOfBeautifulDays;
        }

        public static int reverse(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                reverse = 10 * reverse + number % 10;
                number = number / 10;
            }
            reverse += number;
            return reverse;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}