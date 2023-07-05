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
    public partial class ControlDeAlumnos : Form
    {
        public Materia MateriaSeleccionada { get; set; }
        public ControlDeAlumnos(Materia materia)
        {
            InitializeComponent();
            MateriaSeleccionada = materia;
        }

        private void ControlDeAlumnos_Load(object sender, EventArgs e)
        {
            if (MateriaSeleccionada != null)
            {
                dataGridView1.DataSource = MateriaSeleccionada.estudiantes;
            }
            else
            {
                MessageBox.Show("No hay datos que mostrar");
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
