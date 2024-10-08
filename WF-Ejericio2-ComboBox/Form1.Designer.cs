namespace WF_Ejericio2_ComboBox
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
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbLinux = new System.Windows.Forms.RadioButton();
            this.rbMac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSoftware = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Location = new System.Drawing.Point(6, 20);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(77, 19);
            this.rbWindows.TabIndex = 0;
            this.rbWindows.Text = "Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // rbLinux
            // 
            this.rbLinux.AutoSize = true;
            this.rbLinux.Location = new System.Drawing.Point(6, 45);
            this.rbLinux.Name = "rbLinux";
            this.rbLinux.Size = new System.Drawing.Size(60, 19);
            this.rbLinux.TabIndex = 1;
            this.rbLinux.Text = " Linux";
            this.rbLinux.UseVisualStyleBackColor = true;
            this.rbLinux.CheckedChanged += new System.EventHandler(this.rbLinux_CheckedChanged);
            // 
            // rbMac
            // 
            this.rbMac.AutoSize = true;
            this.rbMac.Location = new System.Drawing.Point(6, 71);
            this.rbMac.Name = "rbMac";
            this.rbMac.Size = new System.Drawing.Size(54, 19);
            this.rbMac.TabIndex = 2;
            this.rbMac.Text = " Mac";
            this.rbMac.UseVisualStyleBackColor = true;
            this.rbMac.CheckedChanged += new System.EventHandler(this.rbMac_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMac);
            this.groupBox1.Controls.Add(this.rbLinux);
            this.groupBox1.Controls.Add(this.rbWindows);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistemas Operativos";
            // 
            // cbSoftware
            // 
            this.cbSoftware.FormattingEnabled = true;
            this.cbSoftware.Location = new System.Drawing.Point(262, 57);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(121, 21);
            this.cbSoftware.TabIndex = 2;
            this.cbSoftware.SelectedIndexChanged += new System.EventHandler(this.cbSoftware_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = " Software Asociado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSoftware);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLinux;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbMac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSoftware;
        private System.Windows.Forms.Label label1;
    }
}

