﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_for_assingment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1 = double.Parse(textBox1.Text);
            double R2 = double.Parse(textBox2.Text);

            double Rt = (R1 + R2);

                MessageBox.Show("Rt = "+Rt+" ohms");
        }
    }
}
