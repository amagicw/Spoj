using System;
using System.Collections.Generic;
using System.Linq;

namespace PP0501A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int> listOfN = new List<int>();
            for(int i = 0; i < n; i++)
            {
                List<int> values = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
                listOfN.Add(Nwd(values[0],values[1]));
            }
            for(int i=0; i< n; i++)
            {
                Console.WriteLine(listOfN[i]);
            }
        }

        public static int Nwd(int a, int b)
        {
            if (a < 0 || a > 1000000 || b < 0 || b > 1000000)
                throw new NotImplementedException();
            
            return Calc(a,b);
        }

        private static void MinLess(ref int a, ref int b)
        {
            if(b>a)
            {
                int c = a;
                a = b;
                b = c;
            }
        }

        private static int Calc(int a, int b)
        {
            MinLess(ref a, ref b);
            if (a - b == 0)
                return b;
            return Calc((a - b), b);
        }
    }
}
