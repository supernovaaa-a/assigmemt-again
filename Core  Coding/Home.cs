using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tutorials toTutorials = new Tutorials();
            toTutorials.Owner = this;
            toTutorials.StartPosition = FormStartPosition.Manual;
            toTutorials.Location = this.Location;
            toTutorials.Show();
            this.Hide();
        }

        private void communityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Community toCommunity = new Community();
            toCommunity.Owner = this;
            toCommunity.StartPosition = FormStartPosition.Manual;
            toCommunity.Location = this.Location;
            toCommunity.Show();
            this.Hide();
        }
    }
}
