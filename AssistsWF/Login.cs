using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistsWF.entities;
using AssistsWF.services;

namespace AssistsWF
{
    public partial class Login : Form
    {
        SecurityService FormSecurityService = new SecurityService();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            var username = textBoxUsuario.Text;
            var password = textBoxContra.Text;

            var UserLogin = FormSecurityService.Login(username, password);
            if (UserLogin != null)
            {
                Inicio inicio = new Inicio(UserLogin);
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
