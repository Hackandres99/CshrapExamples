using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "0";
            for (int i = 0; i <= 255; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = Int32.Parse(comboBox1.Text);
            int g = Int32.Parse(comboBox2.Text);
            int b = Int32.Parse(comboBox3.Text);

            textBox1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
