using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* .NET Lab 1
 * The purpose of this lab is to make sure that that you have the mechanics down for running .NET programs. 
 * Write a console application what will read in a series of  numbers and display their average.   
 * Query the user on how many numbers they will enter.  Do no allow negative numbers.  
 * If the user types in such a number, display a message box containing an error message and continue. 
 */

namespace Lab1
{
    class dotnet_Lab1
    {
        static void Main(string[] args)
        {
            int count = 0;
            string count_input;
            Console.WriteLine("~-AVERAGE NUMBER CALCULATOR-~");
            Console.Write("How many numbers will you be inputting? ");
            count_input = Console.ReadLine();
            count = Convert.ToInt32(count_input);
            while (count < 0)
            {
                Console.Write("Error: number count cannot be negative. Please try again: ");
                count_input = Console.ReadLine();
                count = Convert.ToInt32(count_input);
            }

            double sum = 0;
            string user_input;
            double input;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a number: ");
                user_input = Console.ReadLine();

                input = Convert.ToDouble(user_input);

                if (input < 0)
                {
                    MessageBox.Show("Error: Number is invalid. Continuing...");
                }
                else
                {
                    sum = sum + input;
                }
            }

            Console.WriteLine("The average is: {0}", (sum / count));
            Console.ReadKey();
        }
    }
}
