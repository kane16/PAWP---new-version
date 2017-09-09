using PAWPGUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWPGUI
{
    public partial class NormalDistribution : Form
    {
        public NormalDistribution()
        {
            InitializeComponent();
            chosenPlantsGroup.Visible = false;
            radioAllPlants.Checked = true;
            mineChosenGroup.Visible = false;
            oneLongwallChosenGroup.Visible = false;
            longwallsChosenGroup.Visible = false;
        }

        private void exitButtonNormalDistribution_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButtonNormalDistribution_Hover(object sender, EventArgs e)
        {
            exitButtonNormalDistribution.Image = Resources.Close3b;
        }

        private void exitButtonNormalDistribution_Leave(object sender, EventArgs e)
        {
            exitButtonNormalDistribution.Image = Resources.Close3a;
        }

        private void ChosenPlants_CheckedChanged(object sender, EventArgs e)
        {
            if (radioChosenPlants.Checked)
            {
                chosenPlantsGroup.Visible = true;
            }
            else chosenPlantsGroup.Visible = false;
        }

        private void radioOneMine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOneMine.Checked)
            {
                mineChosenGroup.Visible = true;
            }
            else mineChosenGroup.Visible = false;
        }

        private void radioOneLongwall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOneLongwall.Checked)
            {
                oneLongwallChosenGroup.Visible = true;
            }
            else oneLongwallChosenGroup.Visible = false;
        }

        private void radioChosenLongwalls_CheckedChanged(object sender, EventArgs e)
        {
            if (radioChosenLongwalls.Checked)
            {
                longwallsChosenGroup.Visible = true;
            }
            else longwallsChosenGroup.Visible = false;
        }

        private void runSimulation_Click(object sender, EventArgs e)
        {

        }
    }
}
