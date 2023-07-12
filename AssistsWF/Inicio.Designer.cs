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
            labelSeleccione = new Label();
            buttonAceptar = new Button();
            SuspendLayout();
            // 
            // listMaterias
            // 
            listMaterias.DisplayMember = "None";
            listMaterias.FormattingEnabled = true;
            listMaterias.ItemHeight = 15;
            listMaterias.Location = new Point(96, 90);
            listMaterias.Margin = new Padding(2);
            listMaterias.Name = "listMaterias";
            listMaterias.Size = new Size(184, 49);
            listMaterias.TabIndex = 0;
            listMaterias.SelectedIndexChanged += listMaterias_SelectedIndexChanged;
            // 
            // labelSeleccione
            // 
            labelSeleccione.AutoSize = true;
            labelSeleccione.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccione.Location = new Point(106, 50);
            labelSeleccione.Margin = new Padding(2, 0, 2, 0);
            labelSeleccione.Name = "labelSeleccione";
            labelSeleccione.Size = new Size(160, 20);
            labelSeleccione.TabIndex = 3;
            labelSeleccione.Text = "Seleccione la materia";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(153, 162);
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
            Controls.Add(listMaterias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label labelSeleccione;
        private Button buttonAceptar;
    }
}