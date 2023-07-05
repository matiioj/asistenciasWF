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
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.labelPor = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonIniciar.Location = new System.Drawing.Point(309, 315);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 30);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBienvenido.Location = new System.Drawing.Point(341, 77);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(134, 29);
            this.labelBienvenido.TabIndex = 1;
            this.labelBienvenido.Text = "Bienvenido";
            this.labelBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPor
            // 
            this.labelPor.AutoSize = true;
            this.labelPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPor.Location = new System.Drawing.Point(305, 115);
            this.labelPor.Name = "labelPor";
            this.labelPor.Size = new System.Drawing.Size(212, 25);
            this.labelPor.TabIndex = 2;
            this.labelPor.Text = "Por favor, inicie sesión:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsuario.Location = new System.Drawing.Point(305, 181);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelContra.Location = new System.Drawing.Point(305, 244);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(114, 25);
            this.labelContra.TabIndex = 4;
            this.labelContra.Text = "Contraseña";
            this.labelContra.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(310, 209);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(207, 26);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(309, 270);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(208, 26);
            this.textBoxContra.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelPor);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.buttonIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Label labelPor;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContra;
    }
}

