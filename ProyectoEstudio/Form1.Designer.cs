namespace ProyectoEstudio
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
            this.grbTipoPersona2 = new System.Windows.Forms.GroupBox();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.radEstudiante2 = new System.Windows.Forms.RadioButton();
            this.grbDatos2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtSueldo2 = new System.Windows.Forms.TextBox();
            this.btnCapturarDatos2 = new System.Windows.Forms.Button();
            this.btnMostrarDatos2 = new System.Windows.Forms.Button();
            this.dgvDatos2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCalificacion2 = new System.Windows.Forms.ComboBox();
            this.grbTipoPersona2.SuspendLayout();
            this.grbDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTipoPersona2
            // 
            this.grbTipoPersona2.Controls.Add(this.radEstudiante2);
            this.grbTipoPersona2.Controls.Add(this.radProfesor);
            this.grbTipoPersona2.Location = new System.Drawing.Point(102, 56);
            this.grbTipoPersona2.Name = "grbTipoPersona2";
            this.grbTipoPersona2.Size = new System.Drawing.Size(229, 128);
            this.grbTipoPersona2.TabIndex = 0;
            this.grbTipoPersona2.TabStop = false;
            this.grbTipoPersona2.Text = "Tipo de persona";
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(17, 32);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(64, 17);
            this.radProfesor.TabIndex = 0;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged);
            // 
            // radEstudiante2
            // 
            this.radEstudiante2.AutoSize = true;
            this.radEstudiante2.Location = new System.Drawing.Point(17, 73);
            this.radEstudiante2.Name = "radEstudiante2";
            this.radEstudiante2.Size = new System.Drawing.Size(75, 17);
            this.radEstudiante2.TabIndex = 1;
            this.radEstudiante2.TabStop = true;
            this.radEstudiante2.Text = "Estudiante";
            this.radEstudiante2.UseVisualStyleBackColor = true;
            this.radEstudiante2.CheckedChanged += new System.EventHandler(this.radEstudiante2_CheckedChanged);
            // 
            // grbDatos2
            // 
            this.grbDatos2.Controls.Add(this.txtCalificacion2);
            this.grbDatos2.Controls.Add(this.txtSueldo2);
            this.grbDatos2.Controls.Add(this.txtNombre2);
            this.grbDatos2.Controls.Add(this.label3);
            this.grbDatos2.Controls.Add(this.label2);
            this.grbDatos2.Controls.Add(this.label1);
            this.grbDatos2.Location = new System.Drawing.Point(42, 246);
            this.grbDatos2.Name = "grbDatos2";
            this.grbDatos2.Size = new System.Drawing.Size(205, 123);
            this.grbDatos2.TabIndex = 1;
            this.grbDatos2.TabStop = false;
            this.grbDatos2.Text = "Dato de las personas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificacion";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(88, 30);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 3;
            // 
            // txtSueldo2
            // 
            this.txtSueldo2.Location = new System.Drawing.Point(88, 60);
            this.txtSueldo2.Name = "txtSueldo2";
            this.txtSueldo2.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo2.TabIndex = 4;
            // 
            // btnCapturarDatos2
            // 
            this.btnCapturarDatos2.Location = new System.Drawing.Point(462, 123);
            this.btnCapturarDatos2.Name = "btnCapturarDatos2";
            this.btnCapturarDatos2.Size = new System.Drawing.Size(106, 23);
            this.btnCapturarDatos2.TabIndex = 2;
            this.btnCapturarDatos2.Text = "Capturar datos";
            this.btnCapturarDatos2.UseVisualStyleBackColor = true;
            this.btnCapturarDatos2.Click += new System.EventHandler(this.btnCapturarDatos2_Click);
            // 
            // btnMostrarDatos2
            // 
            this.btnMostrarDatos2.Location = new System.Drawing.Point(472, 161);
            this.btnMostrarDatos2.Name = "btnMostrarDatos2";
            this.btnMostrarDatos2.Size = new System.Drawing.Size(96, 23);
            this.btnMostrarDatos2.TabIndex = 3;
            this.btnMostrarDatos2.Text = "Mostrar datos";
            this.btnMostrarDatos2.UseVisualStyleBackColor = true;
            // 
            // dgvDatos2
            // 
            this.dgvDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Sueldo,
            this.Calificacion});
            this.dgvDatos2.Location = new System.Drawing.Point(365, 230);
            this.dgvDatos2.Name = "dgvDatos2";
            this.dgvDatos2.Size = new System.Drawing.Size(347, 150);
            this.dgvDatos2.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre personas";
            this.Nombre.Name = "Nombre";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo personas";
            this.Sueldo.Name = "Sueldo";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion estudiante";
            this.Calificacion.Name = "Calificacion";
            // 
            // txtCalificacion2
            // 
            this.txtCalificacion2.FormattingEnabled = true;
            this.txtCalificacion2.Location = new System.Drawing.Point(108, 93);
            this.txtCalificacion2.Name = "txtCalificacion2";
            this.txtCalificacion2.Size = new System.Drawing.Size(80, 21);
            this.txtCalificacion2.TabIndex = 5;
            this.txtCalificacion2.SelectedIndexChanged += new System.EventHandler(this.txtCalificacion2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos2);
            this.Controls.Add(this.btnMostrarDatos2);
            this.Controls.Add(this.btnCapturarDatos2);
            this.Controls.Add(this.grbDatos2);
            this.Controls.Add(this.grbTipoPersona2);
            this.Name = "Form1";
            this.Text = "CALIFICACIONES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTipoPersona2.ResumeLayout(false);
            this.grbTipoPersona2.PerformLayout();
            this.grbDatos2.ResumeLayout(false);
            this.grbDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPersona2;
        private System.Windows.Forms.RadioButton radEstudiante2;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.GroupBox grbDatos2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldo2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Button btnCapturarDatos2;
        private System.Windows.Forms.Button btnMostrarDatos2;
        private System.Windows.Forms.DataGridView dgvDatos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.ComboBox txtCalificacion2;
    }
}

