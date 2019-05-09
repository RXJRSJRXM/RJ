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
         Console.WriteLine("吸血蝙蝠之蝙蝠中队 51525303340");
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
   Console.WriteLine("超兽武装 102030405060708090100");
   }
    }
    class  People
    {
     Console.WriteLine("火灵飞 102030405060708090100");
    }
}
