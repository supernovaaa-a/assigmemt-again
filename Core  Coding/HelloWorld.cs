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
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HelloWorld1 tutorial1cont = new HelloWorld1();
            tutorial1cont.Owner = this;
            tutorial1cont.StartPosition = FormStartPosition.Manual;
            tutorial1cont.Location = this.Location;
            tutorial1cont.Show();
            this.Hide();
        }
    }
}
