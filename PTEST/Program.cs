using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = Int32.Parse(Console.ReadLine());
            Int32 b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, b));
        }

        public static int Calculate(int a, int b)
        {
            if (b > 200 || b < 0 || a < 0)
                throw new NotImplementedException();
            return a + b;
        }
    }
}
