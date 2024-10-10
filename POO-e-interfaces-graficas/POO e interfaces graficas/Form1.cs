using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_e_interfaces_graficas
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        Boss boss = new Boss();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int workday;
            if (fullNameBox.Text == "")
            {
                errorProvider1.SetError(fullNameBox, "Debe ingresar un nombre.");
            }else if (DniBox.Text == "")
            {
                errorProvider1.SetError(DniBox, "Debe ingresar un nombre.");
            }
            else if (!Int32.TryParse(workDaysBox.Text, out workday))
            {
                errorProvider1.SetError(workDaysBox, "Debe ingresar un nombre.");
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Datos guardados correctamente",
                    "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (typeCombo.Text == "Empleado")
                {
                    employee.Name = fullNameBox.Text;
                    employee.Dni = DniBox.Text;
                }
                else
                {
                    boss.Name = fullNameBox.Text;
                    boss.Dni = DniBox.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int salary;
            if(typeCombo.Text == "Empleado")
            {
                if(employee.Name != null && employee.Dni != null && workDaysBox.Text != "")
                {
                    salary = employee.calcSalary(Int32.Parse(workDaysBox.Text));
                    salaryResultBox.Text = "El empleado " + employee.Name +
                        " con identificación " + employee.Dni +
                        " Recivira un sueldo de " + salary + " dolares";
                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }    
            }
            else
            {
                if (boss.Name != null && boss.Dni != null && workDaysBox.Text != "")
                {
                    salary = boss.calcSalary(Int32.Parse(workDaysBox.Text));
                    salaryResultBox.Text = "El directivo " + boss.Name +
                        " con identificación " + boss.Dni +
                        " Recivira un sueldo de " + salary +" dolares";
                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullNameBox.Text = "";
            DniBox.Text = "";
            workDaysBox.Text = "";
            salaryResultBox.Text = "";

            if(employee.Name != null && 
                employee.Dni != null && 
                boss.Name != null && 
                boss.Dni != null)
            {
                employee.Name = null;
                employee.Dni = null;
                boss.Name = null;
                boss.Dni = null;

                MessageBox.Show("Datos limpiados correctamente.", 
                    "Información", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }
}
