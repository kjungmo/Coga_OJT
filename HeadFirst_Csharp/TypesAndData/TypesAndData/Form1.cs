using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypesAndData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte myInt;
        private double myByte;
        private bool myDouble;
        private bool myString;
        private byte myBool;
        private string myChar;
        private decimal myLong;

        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte myByte = (byte)myInt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double myDouble = (double)myByte;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool myBool = (bool)myDouble;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string myString = "false";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myBool = (bool)myString;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myString = (string)myInt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myString = myInt.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myBool = (bool)myByte;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myByte = (byte)myBool;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            short myShort = (short)myInt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char myChar = 'x';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myString = (string)myChar;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            long myLong = (long)myInt;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            decimal myDecimal = (decimal)myLong;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myString = myString + myInt + myByte + myDouble + myChar;
        }
    }
}
