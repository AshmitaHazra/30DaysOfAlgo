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

namespace StrongPassword
{
    class StrongPassword
    {
        static int minimumNumber(int n, string password) {
        // Return the minimum number of characters to make the password strong
    int count =0;
    var hasNumber = new Regex(@"[0-9]+");
    var hasUpperChar = new Regex(@"[A-Z]+");
    var hasLowerChar = new Regex(@"[a-z]+");
    var hasSymbols = new Regex(@"[-!@#$%^&*()+]");
    
    if(!hasNumber.IsMatch(password))
    count++;
    if(!hasUpperChar.IsMatch(password))
    count ++;
    if(!hasLowerChar.IsMatch(password))
    count ++;
    if(!hasSymbols.IsMatch(password))
    count ++;
    
    int len = 6 - password.Length;
    if(count < len)
    return len;
    else
    return count;
    }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string password = Console.ReadLine();

            int answer = minimumNumber(n, password);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}