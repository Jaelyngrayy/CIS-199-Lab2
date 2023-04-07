//Grading ID: R5560
//Lab 2
//Due Date: February 7. 2021
//Course Section: CIS 199-01
/*Description: This code takes a price input of any number, and outputs the tip you would give at 15%, 18%. and 20%.
This is all done in a GUI Form */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace Lab2
{
    public partial class tipCalculator : Form
    {
        public tipCalculator()
        {
            InitializeComponent();
        }

        //This click event calculates the tip of an inputted number at 15, 18, and 20 percent. 
        //Done by multiplying the inputted number by .15, .18 and .20 respectively. 
        private void displayTipButton_Click(object sender, EventArgs e)
        {
            double price,
                tip15, // the tip that you would pay at 15%. This is found by multiplying the price by TIP_RATE1, which equals .15
                tip18, // the tip that you would pay at 18%. This is found by multiplying the price by TIP_RATE2, which equals .18
                tip20; // the tip that you would pay at 20%. This is found by multiplying the price by TIP_RATE3, which equals .20

            //These variables never change, so made them named constants
            const double TIP_RATE1 = 0.15; //.15 for 15% tip
            const double TIP_RATE2 = 0.18; //.18 for 18% tip
            const double TIP_RATE3 = 0.20; //.20 for 20% tip

            price = double.Parse(priceTxt.Text); //converts the text put into the priceTXT label into a double

            //calculates tips
            tip15 = price * TIP_RATE1;
            tip18 = price * TIP_RATE2;
            tip20 = price * TIP_RATE3;

            //String interpolation and currency (C) format specifier
            outputLabel15P.Text = $"{tip15:C}";
            outputLabel18P.Text = $"{tip18:C}";
            outputLabel20P.Text = $"{tip20:C}";
        }
    }
}
