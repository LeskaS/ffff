
using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите число: ");
        BigInteger fact = BigInteger.Parse(Console.ReadLine());

        BigInteger fact1 = 1;
        BigInteger n = fact;
        while (n > 0)
        {
            fact1 *= n;
            n--;
        }
        Console.WriteLine("\nРекурсивный способ (факториал):");
        Console.WriteLine(fact1);


        BigInteger fact2 = 1;
        for (BigInteger i = 1; i <= fact; i++)
        {
            fact2 *= i;
        }
        Console.WriteLine("\nИтеративный способ (факториал):");
        Console.WriteLine(fact2);
  
        BigInteger fib1 = 0;
        n = fact;
        BigInteger a = 0, b = 1;
        while (n > 1)
        {
            fib1 = a + b;
            a = b;
            b = fib1;
            n--;
        }
        if (n == 0) fib1 = a;
        else if (n == 1) fib1 = b; 

        Console.WriteLine("\nРекурсивный способ числа Фибоначчи:");
        Console.WriteLine(fib1);

        BigInteger fib2 = 0;
        a = 0;
        b = 1;
        for (BigInteger i = 2; i <= fact; i++)
        {
            fib2 = a + b;
            a = b;
            b = fib2;
        }
        if (fact == 0) fib2 = a; 
        else if (fact == 1) fib2 = b; 

        Console.WriteLine("\nИтеративный способ числа Фибоначчи:");
        Console.WriteLine(fib2);
    }
}



// С double:



//using System;
//using System.Diagnostics;
//using System.Numerics;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число ");
//        double fact = Convert.ToDouble(Console.ReadLine());

//        double fact1 = 1;
//        double n = fact;
//        while (n > 0)
//        {
//            fact1 *= n;
//            n--;
//        }
//        Console.WriteLine("\nрекурсивный способ для факториала:");
//        Console.WriteLine(fact1);


//        double fact2 = 1;
//        for (double i = 1; i <= fact; i++)
//        {
//            fact2 *= i;
//        }
//        Console.WriteLine("\n итеративный способ для факториала:");
//        Console.WriteLine(fact2);

//    }
//}





