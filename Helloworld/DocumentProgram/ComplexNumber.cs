using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class ComplexNumber
    {
        public int real;
        public int imaginary;

        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", real, imaginary);
        }
    }

    class TestComplex
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int real1 = int.Parse(Console.ReadLine());
            int imaginary1 = int.Parse(Console.ReadLine());
            ComplexNumber num1 = new ComplexNumber(real1, imaginary1);

            Console.WriteLine("Enter second number:");
            int real2 = int.Parse(Console.ReadLine());
            int imaginary2 = int.Parse(Console.ReadLine());
            ComplexNumber num2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber sum = num1 + num2;

            Console.WriteLine("First Complex Number :  {0}", num1);
            Console.WriteLine("Second Complex Number : {0}", num2);
            Console.WriteLine(" Sum of Two Numbers : {0}", sum);

            Console.ReadLine();
        }
    }
}
