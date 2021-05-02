using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class BasicCalculatorInterface : BasicAndScientificInterFace
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

    }
}