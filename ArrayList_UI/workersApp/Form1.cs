using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workersApp
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        Boss boss = new Boss();

        ArrayList names = new ArrayList();
        ArrayList dnis = new ArrayList();
        ArrayList workDays = new ArrayList();
        ArrayList workertypes = new ArrayList();
        ArrayList workMonthss = new ArrayList();
        ArrayList actions = new ArrayList();
        ArrayList results = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            for(int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i.ToString()); 
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = 0;
            if (comboBox2.Text == "Empleado")
            {

                if(employee.Name != null && employee.Dni != null && textBox3.Text != "")
                {
                    salary = employee.calcSalary(Int32.Parse(textBox3.Text));
                    names.Add(employee.Name);
                    dnis.Add(employee.Dni);
                    workDays.Add(textBox3.Text);
                    workertypes.Add(comboBox2.Text);
                    workMonthss.Add(comboBox1.Text);
                    actions.Add("Calcular salario");
                    results.Add(salary+" dólares");

                    int p = workTable.Rows.Add();
                    workTable.Rows[p].Cells[0].Value = names[p];
                    workTable.Rows[p].Cells[1].Value = dnis[p];
                    workTable.Rows[p].Cells[2].Value = workDays[p];
                    workTable.Rows[p].Cells[3].Value = workertypes[p];
                    workTable.Rows[p].Cells[5].Value = actions[p];
                    workTable.Rows[p].Cells[6].Value = results[p];

                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                if(boss.Name != null && boss.Dni != null && textBox3.Text != "")
                {
                    salary = boss.calcSalary(Int32.Parse(textBox3.Text));
                    names.Add(boss.Name);
                    dnis.Add(boss.Dni);
                    workDays.Add(textBox3.Text);
                    workertypes.Add(comboBox2.Text);
                    workMonthss.Add(comboBox1.Text);
                    actions.Add("Calcular salario");
                    results.Add(salary+" dólares");

                    int p = workTable.Rows.Add();
                    workTable.Rows[p].Cells[0].Value = names[p];
                    workTable.Rows[p].Cells[1].Value = dnis[p];
                    workTable.Rows[p].Cells[2].Value = workDays[p];
                    workTable.Rows[p].Cells[3].Value = workertypes[p];
                    workTable.Rows[p].Cells[5].Value = actions[p];
                    workTable.Rows[p].Cells[6].Value = results[p];

                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int workDays;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "No puede dejar vacio este campo.");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "No puede dejar vacio este campo.");
                textBox2.Focus();
            }
            else if (!Int32.TryParse(textBox3.Text, out workDays))
            {
                errorProvider1.SetError(textBox3, "Debe ingresar un numero.");
                textBox3.Focus();
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Datos guardados correctamente.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (comboBox2.Text == "Empleado")
                {
                    employee.Name = textBox1.Text;
                    employee.Dni = textBox2.Text;
                }
                else
                {
                    boss.Name = textBox1.Text;
                    boss.Dni = textBox2.Text;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            if (employee.Name != null || employee.Dni != null || 
                boss.Name != null || boss.Dni != null) 
            {
                employee.Name = null;
                employee.Dni = null;
                boss.Name = null;
                boss.Dni = null;
                MessageBox.Show("Datos limpiados correctamente.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vacation = 0;
            if (comboBox2.Text == "Empleado")
            {

                if (employee.Name != null && employee.Dni != null)
                {
                    vacation = employee.calcVacations(Int32.Parse(comboBox1.Text));
                    names.Add(employee.Name);
                    dnis.Add(employee.Dni);
                    workDays.Add(textBox3.Text);
                    workertypes.Add(comboBox2.Text);
                    workMonthss.Add(comboBox1.Text);
                    actions.Add("Calcular vacaciones");
                    results.Add(vacation+" días");

                    int p = workTable.Rows.Add();
                    workTable.Rows[p].Cells[0].Value = names[p];
                    workTable.Rows[p].Cells[1].Value = dnis[p];
                    workTable.Rows[p].Cells[3].Value = workertypes[p];
                    workTable.Rows[p].Cells[4].Value = workMonthss[p];
                    workTable.Rows[p].Cells[5].Value = actions[p];
                    workTable.Rows[p].Cells[6].Value = results[p];
                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                if (boss.Name != null && boss.Dni != null)
                {
                    vacation = boss.calcVacations(Int32.Parse(comboBox1.Text));
                    names.Add(boss.Name);
                    dnis.Add(boss.Dni);
                    workDays.Add(textBox3.Text);
                    workertypes.Add(comboBox2.Text);
                    workMonthss.Add(comboBox1.Text);
                    actions.Add("Calcular vacaciones");
                    results.Add(vacation+" días");

                    int p = workTable.Rows.Add();
                    workTable.Rows[p].Cells[0].Value = names[p];
                    workTable.Rows[p].Cells[1].Value = dnis[p];
                    workTable.Rows[p].Cells[3].Value = workertypes[p];
                    workTable.Rows[p].Cells[4].Value = workMonthss[p];
                    workTable.Rows[p].Cells[5].Value = actions[p];
                    workTable.Rows[p].Cells[6].Value = results[p];
                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox3.ForeColor = Color.Black;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox1.ForeColor = Color.Black;
        }
    }
}
