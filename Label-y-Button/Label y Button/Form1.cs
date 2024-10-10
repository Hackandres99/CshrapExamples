using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_y_Button
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
            modifyText.Text = "Hola mundo con interfaces graficas";
        }
    }
}
