﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant_Project
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Elephant temptoSwap = new Elephant();
            //temptoSwap = lloyd;
            //lloyd = lucinda;
            //lucinda = temptoSwap;
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;

            MessageBox.Show("Object Swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "Hello");
            lloyd.TellMe("Hi", lucinda);
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}