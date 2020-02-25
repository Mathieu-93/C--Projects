using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PrimeNumbers: \n");
            for (int i =2; i < 100; ++i)
            {

                if (IsPrime(i) == true)
                {
                    Console.WriteLine(i + " ");
                }
                else { continue; }
            }
            uint a = 3;
            Console.WriteLine("Factorial of " + a + " is equal to: " + PrintFactorial(a));
            Console.WriteLine();
            Console.ReadKey();
        }

        static double Pythagoras(double a, double b)
        {
            double result;
            result = Math.Sqrt(a * a + b * b);
            return result;
        }

        static bool IsPrime(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
               
            }
            return true;
        }

        static uint PrintFactorial(uint a)
        {
            if (a <= 1) { return 1; }
            else { return a * PrintFactorial(a - 1); }
        }
    }
}
