using System;

class Program
{

    public class NumberTooLargeException : Exception
    {
        public NumberTooLargeException(string message) : base(message) { }
    }


    public class NumberTooSmallException : Exception
    {
        public NumberTooSmallException(string message) : base(message) { }
    }

  
    public class NotANumberException : Exception
    {
        public NotANumberException(string message) : base(message) { }
    }

    public static void CheckNumber(string value)
    {
        try
        {
        
            int num = Convert.ToInt32(value);

      
            if (num < Int32.MinValue)
            {
                throw new NumberTooSmallException("слишком маленькое число");
            }
      
            else if (num > Int32.MaxValue)
            {
                throw new NumberTooLargeException("слишком большое число");
            }

            Console.WriteLine("введенное число: " + num);
        }
        catch (FormatException)
        {
   
            throw new NotANumberException("введено не число");
        }
        catch (OverflowException)
        {
      
            throw new Exception("число выходит за пределы диапазона int");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("введите число ");

        string input = Console.ReadLine();

        try
        {
            CheckNumber(input);
        }
        catch (NotANumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NumberTooLargeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NumberTooSmallException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
