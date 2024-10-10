namespace POOApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.DniBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkDaysBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.workMonths = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tableWork = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWork)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(27, 39);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameBox.TabIndex = 1;
            // 
            // DniBox
            // 
            this.DniBox.Location = new System.Drawing.Point(133, 39);
            this.DniBox.Name = "DniBox";
            this.DniBox.Size = new System.Drawing.Size(100, 20);
            this.DniBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias laborados";
            // 
            // WorkDaysBox
            // 
            this.WorkDaysBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.WorkDaysBox.Location = new System.Drawing.Point(239, 39);
            this.WorkDaysBox.Name = "WorkDaysBox";
            this.WorkDaysBox.Size = new System.Drawing.Size(197, 20);
            this.WorkDaysBox.TabIndex = 5;
            this.WorkDaysBox.Text = "No necesario para calcular vacaciones";
            this.WorkDaysBox.Click += new System.EventHandler(this.WorkDaysBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de trabajador";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Empleado",
            "Directivo"});
            this.typeCombo.Location = new System.Drawing.Point(448, 39);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(100, 21);
            this.typeCombo.TabIndex = 7;
            this.typeCombo.Text = "Empleado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calcular salario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Limpiar datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Meses laborados:";
            // 
            // workMonths
            // 
            this.workMonths.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.workMonths.FormattingEnabled = true;
            this.workMonths.Location = new System.Drawing.Point(567, 39);
            this.workMonths.Name = "workMonths";
            this.workMonths.Size = new System.Drawing.Size(187, 21);
            this.workMonths.TabIndex = 13;
            this.workMonths.Text = "No necesario para calcular salario";
            this.workMonths.SelectedIndexChanged += new System.EventHandler(this.workMonths_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Calcular vacaciones";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableWork
            // 
            this.tableWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dni,
            this.workDays,
            this.workerType,
            this.workMonth,
            this.action,
            this.result});
            this.tableWork.Location = new System.Drawing.Point(12, 121);
            this.tableWork.Name = "tableWork";
            this.tableWork.Size = new System.Drawing.Size(742, 150);
            this.tableWork.TabIndex = 15;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "Identificación";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // workDays
            // 
            this.workDays.HeaderText = "Dias laborados";
            this.workDays.Name = "workDays";
            this.workDays.ReadOnly = true;
            // 
            // workerType
            // 
            this.workerType.HeaderText = "Tipo de trabajador";
            this.workerType.Name = "workerType";
            this.workerType.ReadOnly = true;
            // 
            // workMonth
            // 
            this.workMonth.HeaderText = "Meses laborados";
            this.workMonth.Name = "workMonth";
            this.workMonth.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Acción";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // result
            // 
            this.result.HeaderText = "Resultado";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 292);
            this.Controls.Add(this.tableWork);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.workMonths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WorkDaysBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DniBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.TextBox DniBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkDaysBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox workMonths;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tableWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn workMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}

