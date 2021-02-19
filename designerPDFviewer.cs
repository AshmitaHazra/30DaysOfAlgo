using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace designerPDFviewer
{
    class designerPDFviewer
    {
        static int designerPdfViewer(int[] h, string word)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int i = 0;
            int val;
            int max = int.MinValue;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                map.Add(ch, h[i]);
                i++;
            }
            for (int j = 0; j < word.Length; j++)
            {
                word.ToCharArray();
                char ch = word[j];
                if (map.ContainsKey(ch))
                {
                    val = map[ch];
                    if (val > max)
                        max = val;
                }
            }
            return max * word.Length;

        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
