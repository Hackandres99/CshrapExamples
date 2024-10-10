using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeControls_Click(object sender, EventArgs e)
        {
            modifyText.ForeColor = Color.Green;
            modifyText.Text = sendTextToLabel.Text;

            if(sendTextToLabel.Text == "")
            {
                errorProvider1.SetError(sendTextToLabel, "Debe ingresar un texto");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void sendTextToLabel_MouseClick(object sender, MouseEventArgs e)
        {
            sendTextToLabel.Text = "";
        }
    }
}
