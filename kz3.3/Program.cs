using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Complex z1 = new Complex(6, -3);  
            Complex z2 = new Complex(-4, 2); 

            Console.WriteLine($"Первое число: {z1}");
            Console.WriteLine($"Второе число: {z2}");

            Complex sum = z1 + z2;
            Complex difference = z1 - z2;
            Complex product = z1 * z2;
            Complex quotient = z1 / z2;
            Complex power = Complex.Pow(z1, 2);
            Complex sqrt = Complex.Sqrt(z1);
            double modulus = z1.Abs();
            double angle = z1.Arg();

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Частное: {quotient}");
            Console.WriteLine($"Возведение в квадрат: {power}");
            Console.WriteLine($"Квадратный корень: {sqrt}");
            Console.WriteLine($"Модуль: {modulus}");
            Console.WriteLine($"Угол: {angle} радиан");
        }
    }
}