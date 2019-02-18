using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Simulate the rolling of a pair of dice 100,000 times and display the 
number of 2s, 3s, ....., and 12s rolled.  Do your values make sense?  
Don't hand this lab in unless they do.  Use a push button to start the 
processing and display the results in a label.
*/

namespace dotnet_lab4_redo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Button_Click(object sender, EventArgs e)
        {
            int[] numbers = {0,0,0,0,0,0,0,0,0,0,0}; //enough room for 2-12 
            int num = 0;
            Random rnd = new Random();

            //Get random number and increment count of that number's bucket
            int temp_count;
            int idx;
            for (int i = 0; i < 100000; i++)
            {
                num = rnd.Next(2, 13); //creates a number between 2 and 12
                idx = num - 2; //set index
                temp_count = numbers[idx];  //get the current count for that number
                temp_count += 1; 
                numbers[idx] = temp_count; 
            }

            //Create output string
            string output = "Number of... \r\n";
            for(int i = 0; i < numbers.Length; i++)
            {
                output += (i + 2) + "s: " + numbers[i] + "\r\n";
            }

            //Show output
            Output_Box.Text = output;
        }
    }
}
