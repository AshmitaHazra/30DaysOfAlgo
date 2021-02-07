using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissingAndRepeating
{
    class MissingAndRepeating
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 3, 6, 2, 1, 1 };

            Dictionary<int , Boolean> numberMAp = new Dictionary<int,Boolean>();
            int size = arr.Length;

            foreach (int i in arr)
            {
                if (!numberMAp.ContainsKey(i))
                    numberMAp.Add(i, true);
                else
                    Console.WriteLine("Repeating Key is : "+i);
            }
            for(int i=1; i<=size; i++)
            {
                if (!numberMAp.ContainsKey(i))
                    Console.WriteLine("Missing Key is : " + i);
            }
            Console.ReadLine();
        }
    }
}
