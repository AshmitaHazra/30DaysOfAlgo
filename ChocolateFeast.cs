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


namespace ChocolateFeast
{
    class ChocolateFeast
    {
        static int chocolateFeast(int n, int c, int m)
        {
            int choco = n / c, eat = 0, wp = 0;
            while (choco > 0)
            {  //add until chocolate=0
                eat += choco;
                wp += choco;   //counting no. of chocolates as wrappers
                choco = wp / m;  //No. of wrappers turned
                wp = wp % m;     //left wrappers
            }
            return eat;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(ncm[0]);
                int c = Convert.ToInt32(ncm[1]);
                int m = Convert.ToInt32(ncm[2]);
                int result = chocolateFeast(n, c, m);
                textWriter.WriteLine(result);
            }
            textWriter.Flush();
            textWriter.Close();
        }
    }
}