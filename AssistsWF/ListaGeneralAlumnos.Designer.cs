namespace AssistsWF
{
    partial class ListaGeneralAlumnos
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
            dataGridViewEstudiantes = new DataGridView();
            button_Atras = new Button();
            button_Agregar = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEstudiantes
            // 
            dataGridViewEstudiantes.AllowUserToAddRows = false;
            dataGridViewEstudiantes.AllowUserToDeleteRows = false;
            dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstudiantes.Location = new Point(21, 12);
            dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            dataGridViewEstudiantes.ReadOnly = true;
            dataGridViewEstudiantes.RowTemplate.Height = 25;
            dataGridViewEstudiantes.Size = new Size(767, 386);
            dataGridViewEstudiantes.TabIndex = 0;
            // 
            // button_Atras
            // 
            button_Atras.Location = new Point(713, 415);
            button_Atras.Name = "button_Atras";
            button_Atras.Size = new Size(75, 23);
            button_Atras.TabIndex = 1;
            button_Atras.Text = "Atras";
            button_Atras.UseVisualStyleBackColor = true;
            button_Atras.Click += button_Atras_Click;
            // 
            // button_Agregar
            // 
            button_Agregar.Location = new Point(277, 415);
            button_Agregar.Name = "button_Agregar";
            button_Agregar.Size = new Size(75, 23);
            button_Agregar.TabIndex = 2;
            button_Agregar.Text = "Agregar";
            button_Agregar.UseVisualStyleBackColor = true;
            button_Agregar.Click += button_Agregar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(374, 415);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 3;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(468, 415);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // ListaGeneralAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(button_Agregar);
            Controls.Add(button_Atras);
            Controls.Add(dataGridViewEstudiantes);
            Name = "ListaGeneralAlumnos";
            Text = "ListaGeneralAlumnos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEstudiantes;
        private Button button_Atras;
        private Button button_Agregar;
        private Button buttonEditar;
        private Button buttonEliminar;
    }
}