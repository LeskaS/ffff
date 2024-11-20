
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] mass  = new int[n];
        Random rand = new Random();
        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            mass[i] = rand.Next(1, 101); 
            Console.Write(mass[i] + " ");
        }

        for (int i = 0; i < n - 1; i++) 
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (mass[j] > mass[j + 1]) 
                {
                
                    int num = mass[j];
                    mass[j] = mass[j + 1];
                    mass[j + 1] = num;
                }
            }
        }

        Console.WriteLine("\nОтсортированный массив: " + string.Join(" ", mass ));

    }
}

