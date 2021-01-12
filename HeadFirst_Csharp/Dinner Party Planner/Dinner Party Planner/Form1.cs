using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party_Planner
{
    public partial class partyPlanner : Form
    {

        DinnerParty dinnerParty;
        
        public partyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { numberOfPeople = 5 };
            dinnerParty.setHealthyOption(false);
            dinnerParty.calculateCostOfDecorations(true);
            displayDinnerPartyCost();
        }
        private void displayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.calculateCost(healthyBox.Checked);
            displayCost.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.numberOfPeople = (int)numericUpDown1.Value;
            displayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.calculateCostOfDecorations(fancyBox.Checked);
            displayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.setHealthyOption(healthyBox.Checked);
            displayDinnerPartyCost();
        }
    }
}
