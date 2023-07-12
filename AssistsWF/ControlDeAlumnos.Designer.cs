namespace AssistsWF
{
    partial class ControlDeAlumnosMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAlumnos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreEstudiante = new DataGridViewTextBoxColumn();
            ApellidoEstudiante = new DataGridViewTextBoxColumn();
            Presente = new DataGridViewCheckBoxColumn();
            BtnVolver = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Columns.AddRange(new DataGridViewColumn[] { ID, NombreEstudiante, ApellidoEstudiante, Presente });
            dataGridViewAlumnos.Location = new Point(11, 78);
            dataGridViewAlumnos.Margin = new Padding(2);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersWidth = 62;
            dataGridViewAlumnos.RowTemplate.Height = 28;
            dataGridViewAlumnos.Size = new Size(607, 338);
            dataGridViewAlumnos.TabIndex = 0;
            
            // 
            // ID
            // 
            ID.DataPropertyName = "id_estudiante";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // NombreEstudiante
            // 
            NombreEstudiante.DataPropertyName = "nombre_estudiante";
            NombreEstudiante.HeaderText = "Nombre";
            NombreEstudiante.MinimumWidth = 8;
            NombreEstudiante.Name = "NombreEstudiante";
            NombreEstudiante.ReadOnly = true;
            NombreEstudiante.Width = 150;
            // 
            // ApellidoEstudiante
            // 
            ApellidoEstudiante.DataPropertyName = "apellido_estudiante";
            ApellidoEstudiante.HeaderText = "Apellido";
            ApellidoEstudiante.Name = "ApellidoEstudiante";
            // 
            // Presente
            // 
            Presente.HeaderText = "¿Presente?";
            Presente.MinimumWidth = 8;
            Presente.Name = "Presente";
            Presente.ReadOnly = true;
            Presente.Width = 150;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(271, 430);
            BtnVolver.Margin = new Padding(2);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(58, 22);
            BtnVolver.TabIndex = 1;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(151, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 20);
            label1.TabIndex = 2;
            label1.Text = "Indique si el alumno se encuentra presente";
            // 
            // ControlDeAlumnosMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 459);
            Controls.Add(label1);
            Controls.Add(BtnVolver);
            Controls.Add(dataGridViewAlumnos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "ControlDeAlumnosMateria";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAlumnos;
        private Button BtnVolver;
        private Label label1;
        private Button buttonNuevo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreEstudiante;
        private DataGridViewTextBoxColumn ApellidoEstudiante;
        private DataGridViewCheckBoxColumn Presente;
    }
}