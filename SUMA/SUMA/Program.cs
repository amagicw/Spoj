using System;
using System.Collections.Generic;

namespace SUMA
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            List<int> numbers = new List<int>();
            try
            {
                do
                {
                    n = Int32.Parse(Console.ReadLine());
                    numbers.Add(n);
                } while (n != 0);
            }
            catch(Exception ex)
            {
                DisplaySUM(numbers);
            }
        }

        public static void DisplaySUM(List<int> numbers)
        {
            int sum = 0;
            for(int i=0; i< numbers.Count; i++)
            {
                sum += numbers[i];
                Console.WriteLine(sum);
            }
        }
    }
}
