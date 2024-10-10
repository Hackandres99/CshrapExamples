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

namespace POOApp
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        Boss boss = new Boss();
        /*
         * Implementacion con ArrayList
         * ArrayList nombreColeccion = new ArrayList();
         * Implementacion con HashMap
         * Hashtable nombreColeccion = new Hashtable();
         */
        List<string> names = new List<string>();
        List<string> dnis = new List<string>();
        List<string> workDayss = new List<string>();
        List<string> workerTypes = new List<string>();
        List<string> workMonthss = new List<string>();
        List<string> actions = new List<string>();
        List<string> results = new List<string>();
        public Form1()
        {
            InitializeComponent();
            for(int i = 1; i <= 12; i++)
            {
                workMonths.Items.Add(i.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int workday;
            if(fullNameBox.Text == "")
            {
                errorProvider1.SetError(fullNameBox, "Debe ingresar un nombre.");
            }else if(DniBox.Text == "")
            {
                errorProvider1.SetError(DniBox, "Debe ingresar una identificación.");
            }
            else if(!Int32.TryParse(WorkDaysBox.Text, out workday))
            {
                errorProvider1.SetError(WorkDaysBox, "Debe ingresar una numero.");
            }
            else
            {
                errorProvider1.Clear();
                MessageBox.Show("Datos guardados correctamente.",
                    "Informacion", MessageBoxButtons.OK,
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
                if(employee.Name != null && employee.Dni != null && WorkDaysBox.Text != "")
                {
                    salary = employee.calcSalary(Int32.Parse(WorkDaysBox.Text));
                    int p = tableWork.Rows.Add();
                    /*
                     * Implementacion con ArrayList
                     * nombreColeccion.Add(employee.Name);
                     * Implementacion con HashMap
                     * nombreColeccion.Add(p, employee.Name);
                     */
                    names.Add(employee.Name);
                    dnis.Add(employee.Dni);
                    workDayss.Add(WorkDaysBox.Text);
                    workerTypes.Add(typeCombo.Text);
                    actions.Add("Calcular salario");
                    results.Add(salary + " dólares");

                    
                    tableWork.Rows[p].Cells[0].Value = names[p];
                    tableWork.Rows[p].Cells[1].Value = dnis[p];
                    tableWork.Rows[p].Cells[2].Value = workDayss[p];
                    tableWork.Rows[p].Cells[3].Value = workerTypes[p];
                    tableWork.Rows[p].Cells[4].Value = "";
                    tableWork.Rows[p].Cells[5].Value = actions[p];
                    tableWork.Rows[p].Cells[6].Value = results[p];
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
                if (boss.Name != null && boss.Dni != null && WorkDaysBox.Text != "")
                {
                    salary = boss.calcSalary(Int32.Parse(WorkDaysBox.Text));
                    int p = tableWork.Rows.Add();
                    /*
                     * Implementacion con ArrayList
                     * nombreColeccion.Add(boss.Name);
                     * Implementacion con HashMap
                     * nombreColeccion.Add(p, boss.Name);
                     */
                    names.Add(boss.Name);
                    dnis.Add(boss.Dni);
                    workDayss.Add(WorkDaysBox.Text);
                    workerTypes.Add(typeCombo.Text);
                    actions.Add("Calcular salario");
                    results.Add(salary + " dólares");

                    tableWork.Rows[p].Cells[0].Value = names[p];
                    tableWork.Rows[p].Cells[1].Value = dnis[p];
                    tableWork.Rows[p].Cells[2].Value = workDayss[p];
                    tableWork.Rows[p].Cells[3].Value = workerTypes[p];
                    tableWork.Rows[p].Cells[4].Value = "";
                    tableWork.Rows[p].Cells[5].Value = actions[p];
                    tableWork.Rows[p].Cells[6].Value = results[p];

                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullNameBox.Text = "";
            DniBox.Text = "";
            WorkDaysBox.Text = "";

            if(employee.Name != null || 
                employee.Dni != null || 
                boss.Name != null && 
                boss.Dni != null)
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

        private void button4_Click(object sender, EventArgs e)
        {
            int vacation;
            if (typeCombo.Text == "Empleado")
            {
                if (employee.Name != null && employee.Dni != null)
                {
                    vacation = employee.calcVacation(Int32.Parse(workMonths.Text));
                    int p = tableWork.Rows.Add();
                    /*
                     * Implementacion con ArrayList
                     * nombreColeccion.Add(employee.Name);
                     * Implementacion con HashMap
                     * nombreColeccion.Add(p, employee.Name);
                     */
                    names.Add(employee.Name);
                    dnis.Add(employee.Dni);
                    workMonthss.Add(workMonths.Text);
                    workerTypes.Add(typeCombo.Text);
                    actions.Add("Calcular vacaciones");
                    results.Add(vacation + " días");

                    tableWork.Rows[p].Cells[0].Value = names[p];
                    tableWork.Rows[p].Cells[1].Value = dnis[p];
                    tableWork.Rows[p].Cells[2].Value = "";
                    tableWork.Rows[p].Cells[3].Value = workerTypes[p];
                    tableWork.Rows[p].Cells[4].Value = workMonthss[p];
                    tableWork.Rows[p].Cells[5].Value = actions[p];
                    tableWork.Rows[p].Cells[6].Value = results[p];
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
                    vacation = boss.calcVacation(Int32.Parse(workMonths.Text));
                    int p = tableWork.Rows.Add();
                    /*
                     * Implementacion con ArrayList
                     * nombreColeccion.Add(boss.Name);
                     * Implementacion con HashMap
                     * nombreColeccion.Add(p, boss.Name);
                     */
                    names.Add(boss.Name);
                    dnis.Add(boss.Dni);
                    workMonthss.Add(workMonths.Text);
                    workerTypes.Add(typeCombo.Text);
                    actions.Add("Calcular vacaciones");
                    results.Add(vacation + " días");

                    tableWork.Rows[p].Cells[0].Value = names[p];
                    tableWork.Rows[p].Cells[1].Value = dnis[p];
                    tableWork.Rows[p].Cells[2].Value = "";
                    tableWork.Rows[p].Cells[3].Value = workerTypes[p];
                    tableWork.Rows[p].Cells[4].Value = workMonthss[p];
                    tableWork.Rows[p].Cells[5].Value = actions[p];
                    tableWork.Rows[p].Cells[6].Value = results[p];
                }
                else
                {
                    MessageBox.Show("Debe guardar sus datos.",
                    "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

            }
        }

        private void WorkDaysBox_Click(object sender, EventArgs e)
        {
            WorkDaysBox.Text = string.Empty;
            WorkDaysBox.ForeColor = Color.Black;
        }

        private void workMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            workMonths.Text = string.Empty;
            workMonths.ForeColor = Color.Black;
        }
    }
}
