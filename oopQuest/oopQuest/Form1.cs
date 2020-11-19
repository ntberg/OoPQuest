using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            outputBox.AppendText("you attacked." + Environment.NewLine);
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            outputBox.AppendText("you magic." + Environment.NewLine); ;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
