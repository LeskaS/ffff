

using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static BigInteger factRec(int n)
    {
        if (n == 1 || n == 0) return 1; 
        return n * factRec(n - 1);
    }

    static BigInteger factIt(int n)
    {
        BigInteger fact2 = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            fact2 *= i;
        }
        return fact2; 
    }

    static BigInteger fibRec(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return fibRec(n - 1) + fibRec(n - 2);
    }

    static BigInteger fibIt(int n)
    {
        if (n == 0) return 0;  
        if (n == 1) return 1; 
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger fib2 = 0;
        for (BigInteger i = 2; i <= n; i++)
        {
            fib2 = a + b;
            a = b;
            b = fib2;
        }

        return fib2; 
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine("\nРекурсивный способ (факториал):");
        Console.WriteLine(factRec((int)n));

        Console.WriteLine("\nИтеративный способ (факториал):");
        Console.WriteLine(factIt((int)n));  

        Console.WriteLine("\nРекурсивный способ числа Фибоначчи:");
        Console.WriteLine(fibRec((int)n));  

        Console.WriteLine("\nИтеративный способ числа Фибоначчи:");
        Console.WriteLine(fibIt((int)n)); 
    }
}