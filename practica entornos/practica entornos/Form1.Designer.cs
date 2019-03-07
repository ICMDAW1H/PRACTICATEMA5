namespace practica_entornos
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
            this.TNota = new System.Windows.Forms.TextBox();
            this.TNombre_alumno = new System.Windows.Forms.TextBox();
            this.LNota = new System.Windows.Forms.Label();
            this.LNombre_alumno = new System.Windows.Forms.Label();
            this.LLista = new System.Windows.Forms.Label();
            this.BGuardar_alumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNota
            // 
            this.TNota.Location = new System.Drawing.Point(239, 85);
            this.TNota.Name = "TNota";
            this.TNota.Size = new System.Drawing.Size(100, 20);
            this.TNota.TabIndex = 0;
            // 
            // TNombre_alumno
            // 
            this.TNombre_alumno.Location = new System.Drawing.Point(89, 85);
            this.TNombre_alumno.Name = "TNombre_alumno";
            this.TNombre_alumno.Size = new System.Drawing.Size(100, 20);
            this.TNombre_alumno.TabIndex = 1;
            // 
            // LNota
            // 
            this.LNota.AutoSize = true;
            this.LNota.Location = new System.Drawing.Point(251, 45);
            this.LNota.Name = "LNota";
            this.LNota.Size = new System.Drawing.Size(30, 13);
            this.LNota.TabIndex = 2;
            this.LNota.Text = "Nota";
            // 
            // LNombre_alumno
            // 
            this.LNombre_alumno.AutoSize = true;
            this.LNombre_alumno.Location = new System.Drawing.Point(86, 45);
            this.LNombre_alumno.Name = "LNombre_alumno";
            this.LNombre_alumno.Size = new System.Drawing.Size(81, 13);
            this.LNombre_alumno.TabIndex = 3;
            this.LNombre_alumno.Text = "Nombre alumno";
            // 
            // LLista
            // 
            this.LLista.AutoSize = true;
            this.LLista.Location = new System.Drawing.Point(86, 167);
            this.LLista.Name = "LLista";
            this.LLista.Size = new System.Drawing.Size(86, 13);
            this.LLista.TabIndex = 5;
            this.LLista.Text = "Lista de alumnos";
            // 
            // BGuardar_alumno
            // 
            this.BGuardar_alumno.Location = new System.Drawing.Point(359, 72);
            this.BGuardar_alumno.Name = "BGuardar_alumno";
            this.BGuardar_alumno.Size = new System.Drawing.Size(75, 23);
            this.BGuardar_alumno.TabIndex = 6;
            this.BGuardar_alumno.Text = "Guardar alumno";
            this.BGuardar_alumno.UseVisualStyleBackColor = true;
            this.BGuardar_alumno.Click += new System.EventHandler(this.BGuardar_alumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BGuardar_alumno);
            this.Controls.Add(this.LLista);
            this.Controls.Add(this.LNombre_alumno);
            this.Controls.Add(this.LNota);
            this.Controls.Add(this.TNombre_alumno);
            this.Controls.Add(this.TNota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNota;
        private System.Windows.Forms.TextBox TNombre_alumno;
        private System.Windows.Forms.Label LNota;
        private System.Windows.Forms.Label LNombre_alumno;
        private System.Windows.Forms.Label LLista;
        private System.Windows.Forms.Button BGuardar_alumno;
    }
}

