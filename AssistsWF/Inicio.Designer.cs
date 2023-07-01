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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelHola = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.listBox1.CustomTabOffsets;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(282, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 124);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelHola
            // 
            this.labelHola.AutoSize = true;
            this.labelHola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHola.Location = new System.Drawing.Point(277, 86);
            this.labelHola.Name = "labelHola";
            this.labelHola.Size = new System.Drawing.Size(63, 29);
            this.labelHola.TabIndex = 1;
            this.labelHola.Text = "Hola";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNombre.Location = new System.Drawing.Point(331, 86);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(186, 29);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "nombreprofesor";
            // 
            // labelSeleccione
            // 
            this.labelSeleccione.AutoSize = true;
            this.labelSeleccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSeleccione.Location = new System.Drawing.Point(277, 168);
            this.labelSeleccione.Name = "labelSeleccione";
            this.labelSeleccione.Size = new System.Drawing.Size(204, 25);
            this.labelSeleccione.TabIndex = 3;
            this.labelSeleccione.Text = "Seleccione su materia";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSeleccione);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelHola);
            this.Controls.Add(this.listBox1);
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelHola;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSeleccione;
    }
}