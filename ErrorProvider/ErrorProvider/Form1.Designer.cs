namespace ErrorProvider
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
            this.sendTextToLabel = new System.Windows.Forms.TextBox();
            this.modifyText = new System.Windows.Forms.Label();
            this.ChangeControls = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendTextToLabel
            // 
            this.sendTextToLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sendTextToLabel.Location = new System.Drawing.Point(24, 34);
            this.sendTextToLabel.Name = "sendTextToLabel";
            this.sendTextToLabel.Size = new System.Drawing.Size(146, 20);
            this.sendTextToLabel.TabIndex = 0;
            this.sendTextToLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendTextToLabel_MouseClick);
            // 
            // modifyText
            // 
            this.modifyText.AutoSize = true;
            this.modifyText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.modifyText.Location = new System.Drawing.Point(24, 77);
            this.modifyText.Name = "modifyText";
            this.modifyText.Size = new System.Drawing.Size(64, 13);
            this.modifyText.TabIndex = 1;
            this.modifyText.Text = "Hola mundo";
            // 
            // ChangeControls
            // 
            this.ChangeControls.Location = new System.Drawing.Point(63, 113);
            this.ChangeControls.Name = "ChangeControls";
            this.ChangeControls.Size = new System.Drawing.Size(75, 23);
            this.ChangeControls.TabIndex = 2;
            this.ChangeControls.Text = "Enviar";
            this.ChangeControls.UseVisualStyleBackColor = true;
            this.ChangeControls.Click += new System.EventHandler(this.ChangeControls_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 170);
            this.Controls.Add(this.ChangeControls);
            this.Controls.Add(this.modifyText);
            this.Controls.Add(this.sendTextToLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendTextToLabel;
        private System.Windows.Forms.Label modifyText;
        private System.Windows.Forms.Button ChangeControls;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

