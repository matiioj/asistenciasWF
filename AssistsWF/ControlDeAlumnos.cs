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
    public partial class ControlDeAlumnosMateria : Form
    {
        MateriasService MateriaPorID = new MateriasService();

        public ControlDeAlumnosMateria(Guid materiaID)
        {
            InitializeComponent();
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Materia MateriaSeleccionada = MateriaPorID.GetMateriaID(materiaID);
            if (MateriaSeleccionada != null)
            {
                dataGridViewAlumnos.DataSource = MateriaSeleccionada;
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormRegistroAlumnos FormGestor = new FormRegistroAlumnos(Guid.Empty);
            FormGestor.ShowDialog();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dataGridViewAlumnos.AutoGenerateColumns = false;
            dataGridViewAlumnos.DataSource = null;
        }

    }
}
