namespace AssistsWF
{
    partial class Inicio
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
            listBox1 = new ListBox();
            labelHola = new Label();
            labelNombre = new Label();
            labelSeleccione = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = listBox1.CustomTabOffsets;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(219, 164);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(184, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // labelHola
            // 
            labelHola.AutoSize = true;
            labelHola.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHola.Location = new Point(215, 64);
            labelHola.Margin = new Padding(2, 0, 2, 0);
            labelHola.Name = "labelHola";
            labelHola.Size = new Size(42, 20);
            labelHola.TabIndex = 1;
            labelHola.Text = "Hola";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(257, 64);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(0, 20);
            labelNombre.TabIndex = 2;
            // 
            // labelSeleccione
            // 
            labelSeleccione.AutoSize = true;
            labelSeleccione.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccione.Location = new Point(215, 126);
            labelSeleccione.Margin = new Padding(2, 0, 2, 0);
            labelSeleccione.Name = "labelSeleccione";
            labelSeleccione.Size = new Size(147, 17);
            labelSeleccione.TabIndex = 3;
            labelSeleccione.Text = "Seleccione su materia";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 338);
            Controls.Add(labelSeleccione);
            Controls.Add(labelNombre);
            Controls.Add(labelHola);
            Controls.Add(listBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Inicio";
            ShowIcon = false;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label labelHola;
        private Label labelNombre;
        private Label labelSeleccione;
    }
}