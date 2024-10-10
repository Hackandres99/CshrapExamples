using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrryCatch_y_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Int32.Parse(numberOne.Text);
                int n2 = Int32.Parse(numberTwo.Text);
                textBoxResult.Text = (n1 + n2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hubo un problema al realizar la suma", 
                    "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error );
            }
        }
    }
}
