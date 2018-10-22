using System;
using System.Collections.Generic;
using System.Linq;

namespace POTSAM
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            if(Check(inputs[0]) && Check(inputs[1]) && Check(inputs[2]) && Check(inputs[3]))
            Console.WriteLine(Calculate(inputs[0], inputs[1], inputs[2], inputs[3]));

        }

        public static int Calculate(int n1, int k1, int n2, int k2)
        {
            return (n1 * k1) + (n2 * k2);
        }
        public static bool Check(int value)
        {
            if(value>0 & value <= 1000)
            {
                return true;
            }
            return false;
        }


    }
}
