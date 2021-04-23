using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class variablesPractice : Form
    {
        public variablesPractice()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            //create string varible for Wayne Gretzky
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            answerLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            //find the area of a circle with a radius of 15cm
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            answerLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            //Find the cost to carpet a room 8.5 m by 6 m if the carpet has a price of 19.95 per square meter
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            answerLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2";
            answerLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square metre is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            //calculate and print a bill of sale
            double price = 12.49;
            double bill = 20.00;
            double taxRate = 0.13;
            double taxAmount = price * taxRate;
            double totalPrice = price + taxAmount;
            double change = bill - totalPrice;

            answerLabel.Text = "Bill of Sale";
            answerLabel.Text += $"\n\nShirt:                                              {price}";
            answerLabel.Text += $"\n\nTax:                                               {taxAmount}";
            answerLabel.Text += $"\nTotal:                                          {totalPrice}";
            answerLabel.Text += $"\n\nTendered:                                      {bill}.00";
            answerLabel.Text += $"\nChange:                                       {change}";
        }
    }
}
