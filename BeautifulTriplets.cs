using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BeautifulTriplets
{
    class BeautifulTriplets
    {
        static int beautifulTriplets(int d, int[] arr) {
        int count = 0;
        for(int i=0; i< arr.Length; i++) {
            if( arr.Contains((i + d)) && arr.Contains((i + 2*d)))
                count++;
        }
        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
