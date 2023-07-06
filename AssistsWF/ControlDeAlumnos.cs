using AssistsWF.entities;
using AssistsWF.services;
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
        MateriaPorID MateriaPorID = new MateriaPorID();

        public ControlDeAlumnos(int materiaID)
        {
            InitializeComponent();
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Materia MateriaSeleccionada = MateriaPorID.GetMateriaID(materiaID);
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
