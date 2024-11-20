using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());


        for (int i = 2; i < num; i++)
        {
            bool numb = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    numb = false;
                    break;
                }


            }
            if (numb)
                Console.WriteLine(i);



        }


    }
}
