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
            this.shapes.DataSource = Enum.GetNames(typeof(PyramidShape));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printStars.Text = "";
            printStars.Text = pyramid.CreateStarPyramid();
            if (printStars.Text == " ")
                MessageBox.Show("Choose the shape!");
        }

        private void layers_ValueChanged(object sender, EventArgs e)
        {
            pyramid.LayersOfPyramid = (int)layers.Value;
        }

        private void shapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pyramid.ShapeOfPyramid = shapes.Text;
        }
    }
}
