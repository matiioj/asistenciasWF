namespace AssistsWF
{
    partial class FormGestorAlumnos
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button_Aceptar = new Button();
            button_Atras = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 2;
            // 
            // button_Aceptar
            // 
            button_Aceptar.Location = new Point(184, 198);
            button_Aceptar.Name = "button_Aceptar";
            button_Aceptar.Size = new Size(75, 23);
            button_Aceptar.TabIndex = 3;
            button_Aceptar.Text = "Aceptar";
            button_Aceptar.UseVisualStyleBackColor = true;
            button_Aceptar.Click += button_Aceptar_Click;
            // 
            // button_Atras
            // 
            button_Atras.Location = new Point(351, 198);
            button_Atras.Name = "button_Atras";
            button_Atras.Size = new Size(75, 23);
            button_Atras.TabIndex = 4;
            button_Atras.Text = "Atras";
            button_Atras.UseVisualStyleBackColor = true;
            button_Atras.Click += button_Atras_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 144);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Materias";
            // 
            // FormGestorAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 246);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button_Atras);
            Controls.Add(button_Aceptar);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormGestorAlumnos";
            Text = "Gestor de alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private Button button_Aceptar;
        private Button button_Atras;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}