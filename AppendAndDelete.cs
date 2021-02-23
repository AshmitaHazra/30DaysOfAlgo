using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AppendAndDelete
{
    class AppendAndDelete
    {
        static string appendAndDelete(string s, string t, int k)
        {
            /* Case 1 */
            if (s.Length + t.Length <= k)
            {
                return "Yes";
            }
            /* Case 2 */
            int i = 0; // represents index of 1st non-matching character
            for (; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                {
                    break;
                }
            }
            int minOperations = (s.Length - i) + (t.Length - i);
            if (k >= minOperations && (k - minOperations) % 2 == 0)
                return "Yes";
            else
                return "No";
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = appendAndDelete(s, t, k);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
