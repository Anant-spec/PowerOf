using System;

namespace PowerOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + " raised to the power of " + b + "is:" + Power(a, b));
            Console.ReadLine();
        }

        static int Power(int a, int b)
        {
            int result = 1;

            for (int i= 0; i <b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
