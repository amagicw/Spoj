using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNO_DOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            if (t <= 0 || t >= 100)
                throw new NotImplementedException();

            List<int> returnedValues = new List<int>();
            for(int i = 0;i<t;i++)
            {
                Console.ReadLine();
                string value = Console.ReadLine();
                returnedValues.Add(Calculate(value.Split(new[] { ' ' }).Select(Int32.Parse).ToList()));
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(returnedValues[i]);
            }
        }

        public static int Calculate (List<int> listOfInts)
        {
            int calculation = 0;
            for (int i = 0; i < listOfInts.Count; i++)
            {
                calculation += listOfInts[i];
            }
            return calculation;
        }
    }
}
