using System;
using System.Collections.Generic;

namespace PRIME_T
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0 || n >= 100000)
                throw new NotImplementedException();

            List<bool> primeList = new List<bool>();
            for (int i = 0; i < n; i++)
            {
                int value = Int32.Parse(Console.ReadLine());
                if (value < 1 && value > 10000)
                    throw new NotImplementedException();
                primeList.Add(PrimeNumbers(value, 2));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(primeList[i] == true ? "TAK" : "NIE");
            }
           Console.ReadLine();
        }

        public static bool PrimeNumbers(int value, int counter)
        {
            if(value>1)
            {
                if (counter < value)
                {
                    if(value % counter == 0)
                    {
                        return false;
                    }
                    return PrimeNumbers(value, ++counter);
                }
                return true;
            }
            return false;
        }
    }
}
