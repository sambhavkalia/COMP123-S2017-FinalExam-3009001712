﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sambhav Kalia
 * Date: 17/08/2017
 * StudentID: 300900171
 * Description: This is Splash Form
 * Version: 0.1
 */ 

namespace COMP123_S2017_FinalExam_3009001712
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                timer1.Enabled = false;
                this.Hide();
                PickHighestCardForm pick = new PickHighestCardForm();
                pick.Show();
            }
        }
    }
}
