namespace AssistsWF
{
    partial class FormRegistroAlumnos
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
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            button_Aceptar = new Button();
            button_Atras = new Button();
            label1 = new Label();
            labelApellido = new Label();
            labelMaterias = new Label();
            checkedListBoxMaterias = new CheckedListBox();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(149, 25);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(171, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(149, 65);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(171, 23);
            textBoxApellido.TabIndex = 2;
            // 
            // button_Aceptar
            // 
            button_Aceptar.Location = new Point(189, 223);
            button_Aceptar.Name = "button_Aceptar";
            button_Aceptar.Size = new Size(75, 23);
            button_Aceptar.TabIndex = 3;
            button_Aceptar.Text = "Aceptar";
            button_Aceptar.UseVisualStyleBackColor = true;
            button_Aceptar.Click += button_Aceptar_Click;
            // 
            // button_Atras
            // 
            button_Atras.Location = new Point(368, 223);
            button_Atras.Name = "button_Atras";
            button_Atras.Size = new Size(75, 23);
            button_Atras.TabIndex = 4;
            button_Atras.Text = "Atras";
            button_Atras.UseVisualStyleBackColor = true;
            button_Atras.Click += button_Atras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(67, 73);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 7;
            labelApellido.Text = "Apellido";
            // 
            // labelMaterias
            // 
            labelMaterias.AutoSize = true;
            labelMaterias.Location = new Point(67, 110);
            labelMaterias.Name = "labelMaterias";
            labelMaterias.Size = new Size(52, 15);
            labelMaterias.TabIndex = 8;
            labelMaterias.Text = "Materias";
            // 
            // checkedListBoxMaterias
            // 
            checkedListBoxMaterias.FormattingEnabled = true;
            checkedListBoxMaterias.Location = new Point(149, 110);
            checkedListBoxMaterias.Name = "checkedListBoxMaterias";
            checkedListBoxMaterias.Size = new Size(169, 94);
            checkedListBoxMaterias.TabIndex = 9;
            // 
            // FormRegistroAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 258);
            Controls.Add(checkedListBoxMaterias);
            Controls.Add(labelMaterias);
            Controls.Add(labelApellido);
            Controls.Add(label1);
            Controls.Add(button_Atras);
            Controls.Add(button_Aceptar);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRegistroAlumnos";
            Text = "Registro de alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Button button_Aceptar;
        private Button button_Atras;
        private ComboBox comboBox1;
        private Label label1;
        private Label labelApellido;
        private Label labelMaterias;
        private CheckedListBox checkedListBoxMaterias;
    }
}