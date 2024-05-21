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
    public partial class HelloWorld1 : Form
    {
        public HelloWorld1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input;
            input = textBox1.Text;

            if (input == "Console.WriteLine('Hello World');")
            {
                labelOutput.Text = ("Correct!");
            }
            else if (input == "")
            {
                labelOutput.Text = ("Enter the code:");
            }
            else
            {
                labelOutput.Text = ("Incorrect :(");
            }
        }
    }
}
