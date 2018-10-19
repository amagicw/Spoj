using System;

namespace FCTRL3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int d = Int32.Parse(Console.ReadLine());

            DisplayValues(LoopByFactorial(d));
            Console.ReadLine();
        }

        public static string[] LoopByFactorial(int d)
        {
            string[] values = new string[d];
            if (d < 1 || d > 30)
                throw new NotImplementedException();
            for (int i = 0; i < d; i++)
            {
                long x = Int64.Parse(Console.ReadLine());
                if(x<10)
                {
                    x = Factorial(x);
                    values[i] = $"{x / 10 % 10} {x % 10}";
                }
                else
                {
                    values[i] = $"0 0";
                }

            }
            return values;
        }

        public static long Factorial(long number)
        {
            return number < 2 ? 1 : Factorial(number - 1) * number;
        }
        public static void DisplayValues(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}