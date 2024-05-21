﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core__Coding
{
    public partial class Tutorials : Form
    {
        public Tutorials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void helloWorld_Click(object sender, EventArgs e)
        {
            HelloWorld tutorial1 = new HelloWorld();
            tutorial1.Owner = this;
            tutorial1.StartPosition = FormStartPosition.Manual;
            tutorial1.Location = this.Location;
            tutorial1.Show();
            this.Hide();
        }
    }
}
