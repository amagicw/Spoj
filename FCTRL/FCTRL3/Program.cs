using System;

namespace FCTRL3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int d = Int32.Parse(Console.ReadLine());
            string[] result = new string[d];
            if (d < 1 || d > 30)
                throw new NotImplementedException();
            for (int i = 0; i < d; i++)
            {
                int v = Int32.Parse(Console.ReadLine());
                int x = Factorial(v);
                int numberOfUnities = x % 10;
                int numberOfDozens = x % 100 - numberOfUnities;
                result[i] = $"{numberOfDozens} {numberOfUnities}";
            }
            Console.Write(result);
            //DisplayValues(values);
        }

        public static int Factorial(int number)
        {
            return number < 2 ? 1 : Factorial(number - 1) * number;
        }

        public static void DisplayValues(int[] numbers)
        {
            int counter = numbers.Length;
            for (int i =0; i<counter;i++)
            {
                int numberOfUnities = numbers[i] % 10;
                int numberOfDozens = numbers[1] % 100 - numberOfUnities;
                Console.WriteLine($"{numberOfDozens} {numberOfUnities}");
            }
        }
    }
}
