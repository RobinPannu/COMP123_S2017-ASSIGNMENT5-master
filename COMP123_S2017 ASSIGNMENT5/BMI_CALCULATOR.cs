﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_ASSIGNMENT5
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void HeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                HeightLabel.Text = "inches";
                WeightLabel.Text = "pounds";
            }
        }

    }
}
