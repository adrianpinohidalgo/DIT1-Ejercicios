namespace WF_Ejercicio2_PictureBoxComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMasAncho = new System.Windows.Forms.Button();
            this.btnMenosAncho = new System.Windows.Forms.Button();
            this.btnMenosAlto = new System.Windows.Forms.Button();
            this.btnMasAlto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(88, 35);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.Text = " Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(127, 64);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(46, 64);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = " Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(88, 93);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 3;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = " Ancho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = " Alto";
            // 
            // btnMasAncho
            // 
            this.btnMasAncho.Location = new System.Drawing.Point(441, 34);
            this.btnMasAncho.Name = "btnMasAncho";
            this.btnMasAncho.Size = new System.Drawing.Size(26, 23);
            this.btnMasAncho.TabIndex = 6;
            this.btnMasAncho.Text = " +";
            this.btnMasAncho.UseVisualStyleBackColor = true;
            this.btnMasAncho.Click += new System.EventHandler(this.btnMasAncho_Click);
            // 
            // btnMenosAncho
            // 
            this.btnMenosAncho.Location = new System.Drawing.Point(473, 34);
            this.btnMenosAncho.Name = "btnMenosAncho";
            this.btnMenosAncho.Size = new System.Drawing.Size(26, 23);
            this.btnMenosAncho.TabIndex = 7;
            this.btnMenosAncho.Text = "-";
            this.btnMenosAncho.UseVisualStyleBackColor = true;
            this.btnMenosAncho.Click += new System.EventHandler(this.btnMenosAncho_Click);
            // 
            // btnMenosAlto
            // 
            this.btnMenosAlto.Location = new System.Drawing.Point(473, 88);
            this.btnMenosAlto.Name = "btnMenosAlto";
            this.btnMenosAlto.Size = new System.Drawing.Size(26, 23);
            this.btnMenosAlto.TabIndex = 9;
            this.btnMenosAlto.Text = "-";
            this.btnMenosAlto.UseVisualStyleBackColor = true;
            this.btnMenosAlto.Click += new System.EventHandler(this.btnMenosAlto_Click);
            // 
            // btnMasAlto
            // 
            this.btnMasAlto.Location = new System.Drawing.Point(441, 88);
            this.btnMasAlto.Name = "btnMasAlto";
            this.btnMasAlto.Size = new System.Drawing.Size(26, 23);
            this.btnMasAlto.TabIndex = 8;
            this.btnMasAlto.Text = " +";
            this.btnMasAlto.UseVisualStyleBackColor = true;
            this.btnMasAlto.Click += new System.EventHandler(this.btnMasAlto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 104);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Location = new System.Drawing.Point(46, 157);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(479, 260);
            this.panelImage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.btnMenosAlto);
            this.Controls.Add(this.btnMasAlto);
            this.Controls.Add(this.btnMenosAncho);
            this.Controls.Add(this.btnMasAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasAncho;
        private System.Windows.Forms.Button btnMenosAncho;
        private System.Windows.Forms.Button btnMenosAlto;
        private System.Windows.Forms.Button btnMasAlto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelImage;
    }
}

