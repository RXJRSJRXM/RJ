using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

  int[] intarray1 = { 5, 15, 25, 30, 33, 40 };
            int[] intarray2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var query12 =
                from val1 in intarray1
                join val2 in intarray2 on val1 % 5 equals val2 % 15
                select new { VAL1 = val1, VAL2 = val2 };
            foreach (var val in query12)
            {
                Console.WriteLine(val);
            }
        }
    }
    class  People
    {
     Console.WriteLine("bafsdgdfsfbhjasdgfajsdhfgb11111111111111dsfagif");
    }
}
