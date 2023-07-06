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
            listMaterias = new ListBox();
            labelHola = new Label();
            labelNombre = new Label();
            labelSeleccione = new Label();
            buttonAceptar = new Button();
            SuspendLayout();
            // 
            // listMaterias
            // 
            listMaterias.DisplayMember = "None";
            listMaterias.FormattingEnabled = true;
            listMaterias.ItemHeight = 15;
            listMaterias.Location = new Point(96, 113);
            listMaterias.Margin = new Padding(2);
            listMaterias.Name = "listMaterias";
            listMaterias.Size = new Size(184, 49);
            listMaterias.TabIndex = 0;
            listMaterias.SelectedIndexChanged += listMaterias_SelectedIndexChanged;
            // 
            // labelHola
            // 
            labelHola.AutoSize = true;
            labelHola.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHola.Location = new Point(96, 9);
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
            labelNombre.Location = new Point(142, 9);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(0, 20);
            labelNombre.TabIndex = 2;
            // 
            // labelSeleccione
            // 
            labelSeleccione.AutoSize = true;
            labelSeleccione.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccione.Location = new Point(96, 71);
            labelSeleccione.Margin = new Padding(2, 0, 2, 0);
            labelSeleccione.Name = "labelSeleccione";
            labelSeleccione.Size = new Size(147, 17);
            labelSeleccione.TabIndex = 3;
            labelSeleccione.Text = "Seleccione su materia";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(153, 176);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 4;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(buttonAceptar);
            Controls.Add(labelSeleccione);
            Controls.Add(labelNombre);
            Controls.Add(labelHola);
            Controls.Add(listMaterias);
            Margin = new Padding(2);
            Name = "Inicio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListBox listMaterias;
        private Label labelHola;
        private Label labelNombre;
        private Label labelSeleccione;
        private Button buttonAceptar;
    }
}