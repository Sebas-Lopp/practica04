namespace practica04
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.rbhombre = new System.Windows.Forms.RadioButton();
            this.rbmujer = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(105, 96);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 46);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(253, 53);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(253, 141);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 26);
            this.txtedad.TabIndex = 2;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(253, 190);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 26);
            this.txtestatura.TabIndex = 3;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(253, 234);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 26);
            this.txttelefono.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(253, 96);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 26);
            this.txtapellido.TabIndex = 5;
            // 
            // rbhombre
            // 
            this.rbhombre.AutoSize = true;
            this.rbhombre.Location = new System.Drawing.Point(590, 118);
            this.rbhombre.Name = "rbhombre";
            this.rbhombre.Size = new System.Drawing.Size(91, 24);
            this.rbhombre.TabIndex = 6;
            this.rbhombre.TabStop = true;
            this.rbhombre.Text = "Hombre";
            this.rbhombre.UseVisualStyleBackColor = true;
            // 
            // rbmujer
            // 
            this.rbmujer.AutoSize = true;
            this.rbmujer.Location = new System.Drawing.Point(590, 170);
            this.rbmujer.Name = "rbmujer";
            this.rbmujer.Size = new System.Drawing.Size(73, 24);
            this.rbmujer.TabIndex = 7;
            this.rbmujer.TabStop = true;
            this.rbmujer.Text = "Mujer";
            this.rbmujer.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(105, 183);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 46);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.rbmujer);
            this.Controls.Add(this.rbhombre);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnguardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.RadioButton rbhombre;
        private System.Windows.Forms.RadioButton rbmujer;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

