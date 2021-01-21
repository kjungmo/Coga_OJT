using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        SortingMachine sortingMachine;

        public Form1()
        {
            InitializeComponent();
            sortingMachine = new SortingMachine();
            algorithm.DataSource = Enum.GetNames(typeof(Sorts));
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            outputText.Text = "";
            outputText.Text += sortingMachine.SortInputToOutput(inputText.Text);

        }
    }
}
