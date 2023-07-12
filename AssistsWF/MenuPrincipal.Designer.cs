namespace AssistsWF
{
    partial class MenuPrincipal
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
            labelBienvenido = new Label();
            labelNombre = new Label();
            buttonGestor = new Button();
            buttonAsistencia = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.BackColor = Color.Transparent;
            labelBienvenido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenido.ForeColor = Color.Black;
            labelBienvenido.Location = new Point(238, 59);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(127, 30);
            labelBienvenido.TabIndex = 0;
            labelBienvenido.Text = "Bienvenido ";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(355, 62);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(0, 25);
            labelNombre.TabIndex = 1;
            // 
            // buttonGestor
            // 
            buttonGestor.Location = new Point(224, 251);
            buttonGestor.Name = "buttonGestor";
            buttonGestor.Size = new Size(106, 44);
            buttonGestor.TabIndex = 2;
            buttonGestor.Text = "Gestor de Alumnos";
            buttonGestor.UseVisualStyleBackColor = true;
            buttonGestor.Click += buttonGestor_Click;
            // 
            // buttonAsistencia
            // 
            buttonAsistencia.Location = new Point(432, 251);
            buttonAsistencia.Name = "buttonAsistencia";
            buttonAsistencia.Size = new Size(106, 44);
            buttonAsistencia.TabIndex = 3;
            buttonAsistencia.Text = "Registrar asistencia";
            buttonAsistencia.UseVisualStyleBackColor = true;
            buttonAsistencia.Click += buttonAsistencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 178);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 4;
            label1.Text = "Elija una opcion";
            label1.UseMnemonic = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.purple_background;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(784, 409);
            Controls.Add(label1);
            Controls.Add(buttonAsistencia);
            Controls.Add(buttonGestor);
            Controls.Add(labelNombre);
            Controls.Add(labelBienvenido);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenido;
        private Label labelNombre;
        private Button buttonGestor;
        private Button buttonAsistencia;
        private Label label1;
    }
}