using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculatorInterface c1 = new BasicCalculatorInterface();
            c1.sum(10, 20);
            c1.sub(100, 12);
            c1.multiplication(102, 1234);
            c1.division(12345, 7);

            ScientificCalculatorInterface c2 = new ScientificCalculatorInterface();
            c2.sum(34, 54);
            c2.sub(10, 5);
            c2.multiplication(123, 456);
            c2.division(123, 6);
            c2.XtoY(5, 3);
            c2.Sqroot(103);
            c2.cuberoot(12345);
        }
    }
}
