using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program to find the root of the equation y = x^3 - 2 using the half-interval method
 */

namespace Lab2
{
    class dotnet_Lab2
    {
        static void Main(string[] args)
        {
            double a = -200;
            double b = 300;
            double root = -1;

            while (root == -1)
            {
                //Find middle point
                double c = (a + b) / 2;

                //Verify root
                if (equation(c) == 0.0)
                {
                    root = c;
                }
                else if (equation(a)*equation(c) < 0)
                {
                    b = c;
                }
                else if (equation(b)*equation(c) < 0)
                {
                    a = c;
                }
                else
                {
                    Console.WriteLine("Error: function doesn't follow an assumption of the bisection method");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Root: " + root);
            Console.ReadKey();
            return;
        }

        static double equation(double x)
        {
            //y = x^3 - 2
            return (x * x * x) - 2;
        }
    }
}
