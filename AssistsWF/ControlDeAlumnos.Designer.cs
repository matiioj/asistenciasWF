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
            Alumnos = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Presente = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Alumnos, ID, Presente });
            dataGridView1.Location = new Point(44, 71);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(516, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Alumnos
            // 
            Alumnos.HeaderText = "Alumnos";
            Alumnos.MinimumWidth = 8;
            Alumnos.Name = "Alumnos";
            Alumnos.Width = 150;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Presente
            // 
            Presente.HeaderText = "¿Presente?";
            Presente.MinimumWidth = 8;
            Presente.Name = "Presente";
            Presente.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(273, 450);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(58, 22);
            button1.TabIndex = 1;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
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
            // ControlDeAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 483);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
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
        private DataGridViewTextBoxColumn Alumnos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Presente;
        private Button button1;
        private Label label1;
    }
}