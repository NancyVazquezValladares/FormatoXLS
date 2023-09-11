namespace FormatoXLSxd
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDuracionDias = new System.Windows.Forms.TextBox();
            this.txtDuracionHrs = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(114, 68);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(250, 27);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Departamento de Cursos";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(245, 356);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 34);
            this.Button2.TabIndex = 20;
            this.Button2.Text = "Exportar";
            this.Button2.UseVisualStyleBackColor = true;
           
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(63, 290);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 16);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Dias";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(60, 241);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 16);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Horas";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(37, 185);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 16);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Descripcion";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(60, 136);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 16);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "IdCurso";
            // 
            // txtDuracionDias
            // 
            this.txtDuracionDias.Location = new System.Drawing.Point(133, 287);
            this.txtDuracionDias.Name = "txtDuracionDias";
            this.txtDuracionDias.Size = new System.Drawing.Size(219, 22);
            this.txtDuracionDias.TabIndex = 15;
            // 
            // txtDuracionHrs
            // 
            this.txtDuracionHrs.Location = new System.Drawing.Point(133, 235);
            this.txtDuracionHrs.Name = "txtDuracionHrs";
            this.txtDuracionHrs.Size = new System.Drawing.Size(219, 22);
            this.txtDuracionHrs.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 22);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(133, 136);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(219, 22);
            this.txtIdCurso.TabIndex = 12;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(107, 356);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 31);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Guardar";
            this.Button1.UseVisualStyleBackColor = true;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 437);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtDuracionDias);
            this.Controls.Add(this.txtDuracionHrs);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDuracionDias;
        internal System.Windows.Forms.TextBox txtDuracionHrs;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.TextBox txtIdCurso;
        internal System.Windows.Forms.Button Button1;
    }
}

