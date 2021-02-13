using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonAppetite
{
    class BonAppetite
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
            Console.Read();
        }
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int total = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                total += bill[i];
            }
            total = (total - bill[k]) / 2;
            if (total == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - total);
            }

        }
    }
}
