﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyramids
{
    public partial class Form1 : Form
    {
        Pyramid pyramid;

        public Form1()
        {
            InitializeComponent();
            pyramid = new Pyramid((int)layers.Value, shapes.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printStars.Text = "";
            if ( shapes.Text == Shape.Rightsided.ToString())
            {
                printStars.Text = pyramid.createPyramidRight();
            }

            else if (shapes.Text == Shape.Centered.ToString())
            {
                printStars.Text = pyramid.createPyramidCenter();
            }

            else
            {
                printStars.Text = pyramid.createPyramidReverse();
            }
        }

        private void layers_ValueChanged(object sender, EventArgs e)
        {
            pyramid.LayersOfPyramid = (int)layers.Value;
        }
    }
}
