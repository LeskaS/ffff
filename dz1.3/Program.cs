using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        if (a != 0 & b != 0 & c != 0)
        {
            double d = b * b - 4 * a * c;
            Console.Write("Дискриминант: ");
            Console.WriteLine(d);

            if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.Write("Корень равен: {0} ", x);
            }
            else if (d > 0)
            {
                double x1 = (-b + d) / (2 * a);
                double x2 = (-b - d) / (2 * a);

                Console.Write("Корни x1 и x2  равны: {0}, {1} ", x1, x2);
            }
            else
            {
                Console.WriteLine("нет решений");
            }
        }

        else if (a == 0 & b != 0)
        {
            double x = -c / b;

            Console.Write("Корень  равен: {0} ", x);
        }

        else if (a == 0 & b != 0)
        {
            double x = -c / b;

            Console.Write("Корень  равен: {0} ", x);
        }

        else if (a == 0 & b == 0 & c == 0)

            Console.Write("уравнение имеет бесконечно много решений");

        else if (a == 0 & b == 0 & c != 0)
            Console.Write("нет решений");


    }
}

