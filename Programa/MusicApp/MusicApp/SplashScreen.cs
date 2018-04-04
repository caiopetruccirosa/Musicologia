﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            pgbLoading.Show();
            pgbLoading.Visible = true;
            pgbLoading.Style = ProgressBarStyle.Marquee;
            pgbLoading.MarqueeAnimationSpeed = 30;
        }
    }
}