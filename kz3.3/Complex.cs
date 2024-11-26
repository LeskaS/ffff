using System;

namespace ComplexNumbers
{
    class Complex
    {
        private double _real;
        private double _image;

        public Complex(double r, double i)
        {
            _real = r;
            _image = i;
        }

        public static Complex Add(Complex z1, Complex z2)
        {
            return new Complex(z1._real + z2._real, z1._image + z2._image);
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return Add(z1, z2);
        }

        public static Complex Subtract(Complex z1, Complex z2)
        {
            return new Complex(z1._real - z2._real, z1._image - z2._image);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return Subtract(z1, z2);
        }


        public static Complex Multiply(Complex z1, Complex z2)
        {
            return new Complex(
                z1._real * z2._real - z1._image * z2._image,
                z1._real * z2._image + z2._real * z1._image);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return Multiply(z1, z2);
        }

        public static Complex Divide(Complex z1, Complex z2)
        {
            double den = z2._real * z2._real + z2._image * z2._image;
            
            return new Complex(
                (z1._real * z2._real + z1._image * z2._image) / den,
                (z1._image * z2._real - z1._real * z2._image) / den);
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            return Divide(z1, z2);
        }

      
        public static Complex Pow(Complex z, int power)
        {
            Complex result = new Complex(1, 0); 
            for (int i = 0; i < power; i++)
            {
                result = result * z;
            }
            return result;
        }

        public static Complex Sqrt(Complex z)
        {
            double modulus = z.Abs();
            double angle = z.Arg();
            double sqrtModulus = Math.Sqrt(modulus);
            double sqrtAngle = angle / 2;

            return new Complex(sqrtModulus * Math.Cos(sqrtAngle), sqrtModulus * Math.Sin(sqrtAngle));
        }

        public double Abs()
        {
            return Math.Sqrt(_real * _real + _image * _image);
        }

        public double Arg()
        {
            return Math.Atan2(_image, _real);
        }

        public override string ToString()
        {
            if (_image < 0)
                return $"{_real}{_image}i";  
            else
                return $"{_real}+{_image}i";  
        }
    }
}
