﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = true;
            pictureBox1.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../Release/lexxyBoss3.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
