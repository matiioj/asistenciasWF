namespace AssistsWF
{
    partial class ControlDeAlumnos
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
            dataGridView1 = new DataGridView();
            BtnVolver = new Button();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Estudiante = new DataGridViewTextBoxColumn();
            Presente = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Estudiante, Presente });
            dataGridView1.Location = new Point(44, 71);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(516, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(273, 450);
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
            // ID
            // 
            ID.DataPropertyName = "id_estudiante";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // Estudiante
            // 
            Estudiante.DataPropertyName = "nombre_estudiante";
            Estudiante.HeaderText = "Estudiante";
            Estudiante.MinimumWidth = 8;
            Estudiante.Name = "Estudiante";
            Estudiante.ReadOnly = true;
            Estudiante.Width = 150;
            // 
            // Presente
            // 
            Presente.HeaderText = "¿Presente?";
            Presente.MinimumWidth = 8;
            Presente.Name = "Presente";
            Presente.ReadOnly = true;
            Presente.Width = 150;
            // 
            // ControlDeAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 483);
            Controls.Add(label1);
            Controls.Add(BtnVolver);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "ControlDeAlumnos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnVolver;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewCheckBoxColumn Presente;
    }
}