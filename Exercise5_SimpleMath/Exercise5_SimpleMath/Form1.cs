using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5_SimpleMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = int.Parse(textBox1.Text);
            int second = int.Parse(textBox2.Text);

            label3.Text = $"{first} + {second} = {first + second}";
            label4.Text = $"{first} - {second} = {first - second}";
            label5.Text = $"{first} * {second} = {first * second}";
            label6.Text = $"{first} / {second} = {first / second}";
        }
    }
}
