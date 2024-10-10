using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
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
            sendTextToLabel.Text = "Debe ingresar un texto para enviar";

        }

        private void sendTextToLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendTextToLabel_MouseClick(object sender, MouseEventArgs e)
        {
            sendTextToLabel.Text = "";
        }
    }
}
