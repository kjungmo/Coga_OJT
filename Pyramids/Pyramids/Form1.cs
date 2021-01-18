using System;
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
            if (shapes.Text == "Right-sided")
            {
                printStars.Text = pyramid.createPyramidRight((int)layers.Value);
            }

            else if (shapes.Text == "Centered")
            {
                printStars.Text = pyramid.createPyramidCenter((int)layers.Value);
            }

            else
            {
                printStars.Text = pyramid.createPyramidReverse((int)layers.Value);
            }
        }
    }
}
