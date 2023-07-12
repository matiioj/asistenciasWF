using AssistsWF.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistsWF
{
    public partial class MenuPrincipal : Form
    {
        public Usuario UserSession;
        public MenuPrincipal(Usuario returned)
        {
            InitializeComponent();
            UserSession = returned;
            labelNombre.Text = UserSession.Nombre + " " + UserSession.Apellido;
        }

        private void buttonGestor_Click(object sender, EventArgs e)
        {
            ListaGeneralAlumnos listaGestion = new ListaGeneralAlumnos();
            listaGestion.Show();
        }

        private void buttonAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
