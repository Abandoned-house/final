﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbandonedHouse
{
    public partial class GettingIn: Form
    {
        public GettingIn()
        {
            InitializeComponent();
        }

        private void btn_GettingIn_Click(object sender, EventArgs e)
        {
            new SearchingForLight().Show();
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new theEnding().Show();
            this.Visible = false;

        }
    }
}
