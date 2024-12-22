using System;
using System.IO;

class Program
{
    static void Main()
    {
      
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "f.txt");

        try
        {
       
            string[] lines = new string[12];
            lines[0] = "x\tsin(x)"; 

            int index = 1;
            for (double x = 0; x <= 1.0; x += 0.1)
            {
                double sinValue = Math.Sin(x);
                lines[index++] = string.Format("{0:F1}\t{1:F4}", x, sinValue);
            }

            File.WriteAllLines(filePath, lines);

            Console.WriteLine($"Таблица  записана в файл \"{filePath}\".");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
