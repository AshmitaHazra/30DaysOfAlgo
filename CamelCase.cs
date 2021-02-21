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

namespace CamelCase
{
    class CamelCase
    {
        static int camelcase(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count + 1;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string s = Console.ReadLine();
            int result = camelcase(s);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
