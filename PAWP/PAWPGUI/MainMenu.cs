using PAWPController;
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
    public partial class MainMenu : Form
    {

        CLongwall wall1;
        CLongwall wall2;
        CLongwall wall3;
        CLongwall wall4;

        public MainMenu()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            newMineGroup.Visible = false;
            newLongwallGroup.Visible = false;
            wall1 = new CLongwall(1, "Nowa ściana", "ściana 1", 85, false, 34.4, 56.8, 466.6, 18, 5.3,
            3.9, 0.5, 0, 0, 1, 4, 30.9, 32.5, 22.03, 3570);
            wall2 = new CLongwall(1, "Nowa ściana", "ściana 1", 95, false, 34.4, 56.8, 466.6, 22, 2.3,
            4.9, 1.5, 0, 0, 1, 4, 30.9, 32.5, 22.03, 3570);
            wall3 = new CLongwall(1, "Nowa ściana", "ściana 1", 105, false, 34.4, 56.8, 466.6, 33, 1.3,
            5.9, 2.5, 0, 0, 1, 4, 30.9, 32.5, 22.03, 3570);
            wall4 = new CLongwall(1, "Nowa ściana", "ściana 1", 205, false, 34.4, 56.8, 466.6, 44, 4.3,
            6.9, 3.5, 0, 0, 1, 4, 30.9, 32.5, 22.03, 3570);
            CLongwall.LDr = 252;
            CLongwall.DPSN = true;
            CLongwall.SCzP = false;
            CLongwall.LDWP = 47;
            CLongwall.LSAO = 7;
            minesInProgram.Items.Add("Kopalnia 1");
            minesInProgram.Items.Add("Kopalnia 2");
        }

        private void longwallsAvaliableToInProgram_Click(object sender, EventArgs e)
        {

        }

        private void longwallsInProgramToAvaliable_Click(object sender, EventArgs e)
        {

        }

        private void minesAvaliableToInProgram_Click(object sender, EventArgs e)
        {

        }

        private void minesInProgramToAvaliable_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NormalDistribution normal = new NormalDistribution();
            normal.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_mouseHover(object sender, EventArgs e)
        {
            exitButton.Image = Resources.Close3b;
        }

        private void exitButton_mouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Resources.Close3a;
        }

        private void wantNewMine_CheckedChanged(object sender, EventArgs e)
        {
            if (wantNewMine.Checked)
            {
                newMineGroup.Visible = true;
            }
            else newMineGroup.Visible = false;
        }

        private void wantNewLongwall_CheckedChanged(object sender, EventArgs e)
        {
            if (wantNewLongwall.Checked)
            {
                newLongwallGroup.Visible = true;
            }
            else newLongwallGroup.Visible = false;
        }
    }
}
