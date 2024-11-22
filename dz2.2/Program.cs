
using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите число: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        int fact1(int n)
        {
            if (n == 1) return 1;

            return n * fact1(n - 1);
        }

        Console.WriteLine("\nРекурсивный способ (факториал):");
        Console.WriteLine(fact1((int)n));



        BigInteger fact2 = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            fact2 *= i;
        }
        Console.WriteLine("\nИтеративный способ (факториал):");
        Console.WriteLine(fact2);

        BigInteger fib1(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fib1(n - 1) + fib1(n - 2);
        }

        Console.WriteLine("\nРекурсивный способ числа Фибоначчи:");
        Console.WriteLine(fib1((int)n));

        BigInteger fib2 = 0;
        BigInteger a = 0;
        BigInteger  b = 1;
        for (BigInteger i = 2; i <= n; i++)
        {
            fib2 = a + b;
            a = b;
            b = fib2;
        }
        if (n == 0) fib2 = a; 
        else if (n == 1) fib2 = b; 

        Console.WriteLine("\nИтеративный способ числа Фибоначчи:");
        Console.WriteLine(fib2);
    }
}


