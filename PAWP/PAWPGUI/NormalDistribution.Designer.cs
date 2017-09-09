namespace PAWPGUI
{
    partial class NormalDistribution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButtonNormalDistribution = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mineChosenGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oneLongwallChosenGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.longwallsChosenGroup = new System.Windows.Forms.GroupBox();
            this.LongwallsList = new System.Windows.Forms.ListBox();
            this.radioChosenPlants = new System.Windows.Forms.RadioButton();
            this.radioAllPlants = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chosenPlantsGroup = new System.Windows.Forms.GroupBox();
            this.radioChosenLongwalls = new System.Windows.Forms.RadioButton();
            this.radioOneLongwall = new System.Windows.Forms.RadioButton();
            this.radioOneMine = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.runSimulation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitButtonNormalDistribution)).BeginInit();
            this.mineChosenGroup.SuspendLayout();
            this.oneLongwallChosenGroup.SuspendLayout();
            this.longwallsChosenGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.chosenPlantsGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButtonNormalDistribution
            // 
            this.exitButtonNormalDistribution.Image = global::PAWPGUI.Properties.Resources.Close3a;
            this.exitButtonNormalDistribution.Location = new System.Drawing.Point(1585, 12);
            this.exitButtonNormalDistribution.Name = "exitButtonNormalDistribution";
            this.exitButtonNormalDistribution.Size = new System.Drawing.Size(53, 51);
            this.exitButtonNormalDistribution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButtonNormalDistribution.TabIndex = 4;
            this.exitButtonNormalDistribution.TabStop = false;
            this.exitButtonNormalDistribution.Click += new System.EventHandler(this.exitButtonNormalDistribution_Click);
            this.exitButtonNormalDistribution.MouseLeave += new System.EventHandler(this.exitButtonNormalDistribution_Leave);
            this.exitButtonNormalDistribution.MouseHover += new System.EventHandler(this.exitButtonNormalDistribution_Hover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(585, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Distribution type: Normal";
            // 
            // mineChosenGroup
            // 
            this.mineChosenGroup.Controls.Add(this.label2);
            this.mineChosenGroup.Controls.Add(this.comboBox1);
            this.mineChosenGroup.Location = new System.Drawing.Point(23, 51);
            this.mineChosenGroup.Name = "mineChosenGroup";
            this.mineChosenGroup.Size = new System.Drawing.Size(197, 111);
            this.mineChosenGroup.TabIndex = 7;
            this.mineChosenGroup.TabStop = false;
            this.mineChosenGroup.Text = "Mine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mine name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // oneLongwallChosenGroup
            // 
            this.oneLongwallChosenGroup.Controls.Add(this.label4);
            this.oneLongwallChosenGroup.Controls.Add(this.comboBox3);
            this.oneLongwallChosenGroup.Controls.Add(this.label3);
            this.oneLongwallChosenGroup.Controls.Add(this.comboBox2);
            this.oneLongwallChosenGroup.Location = new System.Drawing.Point(23, 199);
            this.oneLongwallChosenGroup.Name = "oneLongwallChosenGroup";
            this.oneLongwallChosenGroup.Size = new System.Drawing.Size(197, 152);
            this.oneLongwallChosenGroup.TabIndex = 8;
            this.oneLongwallChosenGroup.TabStop = false;
            this.oneLongwallChosenGroup.Text = "Longwall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Longwall name";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(32, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mine name";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(32, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // longwallsChosenGroup
            // 
            this.longwallsChosenGroup.Controls.Add(this.LongwallsList);
            this.longwallsChosenGroup.Location = new System.Drawing.Point(23, 406);
            this.longwallsChosenGroup.Name = "longwallsChosenGroup";
            this.longwallsChosenGroup.Size = new System.Drawing.Size(197, 194);
            this.longwallsChosenGroup.TabIndex = 8;
            this.longwallsChosenGroup.TabStop = false;
            this.longwallsChosenGroup.Text = "Longwalls";
            // 
            // LongwallsList
            // 
            this.LongwallsList.FormattingEnabled = true;
            this.LongwallsList.Location = new System.Drawing.Point(18, 20);
            this.LongwallsList.Name = "LongwallsList";
            this.LongwallsList.Size = new System.Drawing.Size(160, 160);
            this.LongwallsList.TabIndex = 0;
            // 
            // radioChosenPlants
            // 
            this.radioChosenPlants.AutoSize = true;
            this.radioChosenPlants.Location = new System.Drawing.Point(18, 38);
            this.radioChosenPlants.Name = "radioChosenPlants";
            this.radioChosenPlants.Size = new System.Drawing.Size(92, 17);
            this.radioChosenPlants.TabIndex = 9;
            this.radioChosenPlants.TabStop = true;
            this.radioChosenPlants.Text = "Chosen plants";
            this.radioChosenPlants.UseVisualStyleBackColor = true;
            this.radioChosenPlants.CheckedChanged += new System.EventHandler(this.ChosenPlants_CheckedChanged);
            // 
            // radioAllPlants
            // 
            this.radioAllPlants.AutoSize = true;
            this.radioAllPlants.Location = new System.Drawing.Point(18, 15);
            this.radioAllPlants.Name = "radioAllPlants";
            this.radioAllPlants.Size = new System.Drawing.Size(67, 17);
            this.radioAllPlants.TabIndex = 10;
            this.radioAllPlants.TabStop = true;
            this.radioAllPlants.Text = "All plants";
            this.radioAllPlants.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioChosenPlants);
            this.panel1.Controls.Add(this.radioAllPlants);
            this.panel1.Location = new System.Drawing.Point(35, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 77);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(31, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Simulation diversed for:";
            // 
            // chosenPlantsGroup
            // 
            this.chosenPlantsGroup.Controls.Add(this.radioChosenLongwalls);
            this.chosenPlantsGroup.Controls.Add(this.longwallsChosenGroup);
            this.chosenPlantsGroup.Controls.Add(this.radioOneLongwall);
            this.chosenPlantsGroup.Controls.Add(this.oneLongwallChosenGroup);
            this.chosenPlantsGroup.Controls.Add(this.radioOneMine);
            this.chosenPlantsGroup.Controls.Add(this.mineChosenGroup);
            this.chosenPlantsGroup.Location = new System.Drawing.Point(12, 204);
            this.chosenPlantsGroup.Name = "chosenPlantsGroup";
            this.chosenPlantsGroup.Size = new System.Drawing.Size(258, 606);
            this.chosenPlantsGroup.TabIndex = 16;
            this.chosenPlantsGroup.TabStop = false;
            this.chosenPlantsGroup.Text = "chosenPlants";
            // 
            // radioChosenLongwalls
            // 
            this.radioChosenLongwalls.AutoSize = true;
            this.radioChosenLongwalls.Location = new System.Drawing.Point(23, 383);
            this.radioChosenLongwalls.Name = "radioChosenLongwalls";
            this.radioChosenLongwalls.Size = new System.Drawing.Size(110, 17);
            this.radioChosenLongwalls.TabIndex = 17;
            this.radioChosenLongwalls.TabStop = true;
            this.radioChosenLongwalls.Text = "chosen Longwalls";
            this.radioChosenLongwalls.UseVisualStyleBackColor = true;
            this.radioChosenLongwalls.CheckedChanged += new System.EventHandler(this.radioChosenLongwalls_CheckedChanged);
            // 
            // radioOneLongwall
            // 
            this.radioOneLongwall.AutoSize = true;
            this.radioOneLongwall.Location = new System.Drawing.Point(23, 176);
            this.radioOneLongwall.Name = "radioOneLongwall";
            this.radioOneLongwall.Size = new System.Drawing.Size(88, 17);
            this.radioOneLongwall.TabIndex = 11;
            this.radioOneLongwall.TabStop = true;
            this.radioOneLongwall.Text = "one Longwall";
            this.radioOneLongwall.UseVisualStyleBackColor = true;
            this.radioOneLongwall.CheckedChanged += new System.EventHandler(this.radioOneLongwall_CheckedChanged);
            // 
            // radioOneMine
            // 
            this.radioOneMine.AutoSize = true;
            this.radioOneMine.Location = new System.Drawing.Point(23, 28);
            this.radioOneMine.Name = "radioOneMine";
            this.radioOneMine.Size = new System.Drawing.Size(69, 17);
            this.radioOneMine.TabIndex = 12;
            this.radioOneMine.TabStop = true;
            this.radioOneMine.Text = "one Mine";
            this.radioOneMine.UseVisualStyleBackColor = true;
            this.radioOneMine.CheckedChanged += new System.EventHandler(this.radioOneMine_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(381, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 499);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.runSimulation);
            this.groupBox2.Location = new System.Drawing.Point(381, 640);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 350);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Data";
            // 
            // runSimulation
            // 
            this.runSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runSimulation.Location = new System.Drawing.Point(839, 284);
            this.runSimulation.Name = "runSimulation";
            this.runSimulation.Size = new System.Drawing.Size(236, 47);
            this.runSimulation.TabIndex = 0;
            this.runSimulation.Text = "Run Simulation";
            this.runSimulation.UseVisualStyleBackColor = true;
            this.runSimulation.Click += new System.EventHandler(this.runSimulation_Click);
            // 
            // NormalDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1650, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chosenPlantsGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtonNormalDistribution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NormalDistribution";
            this.Text = "NormalDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.exitButtonNormalDistribution)).EndInit();
            this.mineChosenGroup.ResumeLayout(false);
            this.mineChosenGroup.PerformLayout();
            this.oneLongwallChosenGroup.ResumeLayout(false);
            this.oneLongwallChosenGroup.PerformLayout();
            this.longwallsChosenGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chosenPlantsGroup.ResumeLayout(false);
            this.chosenPlantsGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButtonNormalDistribution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mineChosenGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox oneLongwallChosenGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox longwallsChosenGroup;
        private System.Windows.Forms.RadioButton radioChosenPlants;
        private System.Windows.Forms.RadioButton radioAllPlants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox chosenPlantsGroup;
        private System.Windows.Forms.ListBox LongwallsList;
        private System.Windows.Forms.RadioButton radioChosenLongwalls;
        private System.Windows.Forms.RadioButton radioOneLongwall;
        private System.Windows.Forms.RadioButton radioOneMine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button runSimulation;
    }
}