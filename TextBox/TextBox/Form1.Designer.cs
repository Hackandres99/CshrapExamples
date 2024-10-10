namespace TextBox
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
            this.sendTextToLabel = new System.Windows.Forms.TextBox();
            this.modifyText = new System.Windows.Forms.Label();
            this.ChangeControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendTextToLabel
            // 
            this.sendTextToLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sendTextToLabel.Location = new System.Drawing.Point(12, 41);
            this.sendTextToLabel.Name = "sendTextToLabel";
            this.sendTextToLabel.Size = new System.Drawing.Size(100, 20);
            this.sendTextToLabel.TabIndex = 0;
            this.sendTextToLabel.Text = "Ingrese un texto para enviar";
            this.sendTextToLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendTextToLabel_MouseClick);
            this.sendTextToLabel.TextChanged += new System.EventHandler(this.sendTextToLabel_TextChanged);
            // 
            // modifyText
            // 
            this.modifyText.AutoSize = true;
            this.modifyText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.modifyText.Location = new System.Drawing.Point(12, 77);
            this.modifyText.Name = "modifyText";
            this.modifyText.Size = new System.Drawing.Size(64, 13);
            this.modifyText.TabIndex = 1;
            this.modifyText.Text = "Hola mundo";
            // 
            // ChangeControls
            // 
            this.ChangeControls.Location = new System.Drawing.Point(60, 110);
            this.ChangeControls.Name = "ChangeControls";
            this.ChangeControls.Size = new System.Drawing.Size(75, 23);
            this.ChangeControls.TabIndex = 2;
            this.ChangeControls.Text = "Enviar";
            this.ChangeControls.UseVisualStyleBackColor = true;
            this.ChangeControls.Click += new System.EventHandler(this.ChangeControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 164);
            this.Controls.Add(this.ChangeControls);
            this.Controls.Add(this.modifyText);
            this.Controls.Add(this.sendTextToLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendTextToLabel;
        private System.Windows.Forms.Label modifyText;
        private System.Windows.Forms.Button ChangeControls;
    }
}

