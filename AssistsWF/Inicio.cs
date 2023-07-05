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

namespace AssistsWF
{
    public partial class Inicio : Form
    {
        public Usuario UserSession;

        public Inicio(Usuario returned)
        {
            InitializeComponent();
            UserSession = returned;
            labelNombre.Text = returned.Nombre + "" + returned.Apellido;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
