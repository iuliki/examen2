using System;

namespace factorial_recursiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
        }
        
        public static int Factorial(int n)
        { 
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
