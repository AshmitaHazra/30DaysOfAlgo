using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staircase.cs
{
    class Staircase
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
        static void staircase(int n)
        {
            char ch = '#';
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
