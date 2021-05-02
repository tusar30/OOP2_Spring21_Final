using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ScientificCalculatorInterface : BasicAndScientificInterFace, Extension
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("The sum is : " + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("The sub is : " + (a - b));
        }
        public void multiplication(int a, int b)
        {
            Console.WriteLine("The multiplication is : " + (a * b));
        }
        public void division(double a, double b)
        {
            Console.WriteLine("The division is : " + (a / b));
        }
        public void XtoY(double x, double y)
        {
            double pow_ab = Math.Pow(x, y);
            Console.WriteLine("X power Y is : " + pow_ab);
        }
        public void Sqroot(double x)
        {
            Console.WriteLine("square root of " + x + " is :" + Math.Sqrt(x));
        }

        public void cuberoot(double x)
        {
            Console.WriteLine("Cube root is :" + Math.Ceiling(Math.Pow(x, (double)1 / 3)));
        }
    }
}