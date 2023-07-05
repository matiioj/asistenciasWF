namespace AssistsWF
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            buttonIniciar = new Button();
            labelBienvenido = new Label();
            labelPor = new Label();
            labelUsuario = new Label();
            labelContra = new Label();
            textBoxUsuario = new TextBox();
            textBoxContra = new TextBox();
            SuspendLayout();
            // 
            // buttonIniciar
            // 
            buttonIniciar.Anchor = AnchorStyles.None;
            buttonIniciar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIniciar.Location = new Point(214, 264);
            buttonIniciar.Margin = new Padding(2);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(58, 22);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // labelBienvenido
            // 
            labelBienvenido.Anchor = AnchorStyles.None;
            labelBienvenido.AutoSize = true;
            labelBienvenido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenido.Location = new Point(239, 86);
            labelBienvenido.Margin = new Padding(2, 0, 2, 0);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(87, 20);
            labelBienvenido.TabIndex = 1;
            labelBienvenido.Text = "Bienvenido";
            // 
            // labelPor
            // 
            labelPor.Anchor = AnchorStyles.None;
            labelPor.AutoSize = true;
            labelPor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPor.Location = new Point(211, 114);
            labelPor.Margin = new Padding(2, 0, 2, 0);
            labelPor.Name = "labelPor";
            labelPor.Size = new Size(155, 17);
            labelPor.TabIndex = 2;
            labelPor.Text = "Por favor, inicie sesión:";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.None;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(211, 164);
            labelUsuario.Margin = new Padding(2, 0, 2, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(57, 17);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            // 
            // labelContra
            // 
            labelContra.Anchor = AnchorStyles.None;
            labelContra.AutoSize = true;
            labelContra.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelContra.Location = new Point(211, 211);
            labelContra.Margin = new Padding(2, 0, 2, 0);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(81, 17);
            labelContra.TabIndex = 4;
            labelContra.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.Location = new Point(215, 185);
            textBoxUsuario.Margin = new Padding(2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(162, 23);
            textBoxUsuario.TabIndex = 5;
            // 
            // textBoxContra
            // 
            textBoxContra.Anchor = AnchorStyles.None;
            textBoxContra.Location = new Point(214, 230);
            textBoxContra.Margin = new Padding(2);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(163, 23);
            textBoxContra.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelContra);
            Controls.Add(labelUsuario);
            Controls.Add(labelPor);
            Controls.Add(labelBienvenido);
            Controls.Add(buttonIniciar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIniciar;
        private Label labelBienvenido;
        private Label labelPor;
        private Label labelUsuario;
        private Label labelContra;
        private TextBox textBoxUsuario;
        private TextBox textBoxContra;
    }
}

