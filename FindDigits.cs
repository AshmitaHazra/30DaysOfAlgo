﻿using System.CodeDom.Compiler;
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

namespace FindDigits
{
    class FindDigits
    {
        static int findDigits(int n)
        {
            int r = n;
            int count = 0;
            while (r > 0)
            {
                if (r % 10 != 0 && n % (r % 10) == 0) count++;
                r = r / 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
