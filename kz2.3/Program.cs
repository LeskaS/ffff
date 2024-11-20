using System;
class Program
{
    static int Change(int num)
    {
        int k = 0; 
        while (num != 1) 
        {
            if (num % 2 == 0) 
            {
                num = num / 2;
                Console.WriteLine("Используем num = num / 2 : {0}", num);
                
            }
            else 
            {
                num = 3 * num + 1;
                Console.WriteLine(" num = 3 * num + 1", num);
            }

            k++;
       
        }

        return k; 
    }

    static void Main()
    {
       
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Change(num);
        Console.WriteLine($"Число замен, ведущих к 1: {result}");
    }
}
