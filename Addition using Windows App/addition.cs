using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1, input2, sum;

            input1 = Convert.ToInt32(textBox1.Text);
            input2 = Convert.ToInt32(textBox2.Text);

            sum = input1 + input2;

            textBox3.Text = sum.ToString();
        }
    }
}
