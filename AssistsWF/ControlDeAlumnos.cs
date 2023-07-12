﻿using AssistsWF.entities;
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
        MateriasService materiasService = new MateriasService();
        AsignacionesService asignacionesService = new();

        public ControlDeAlumnosMateria(Guid materiaID)
        {
            InitializeComponent();
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Materia MateriaSeleccionada = materiasService.GetMateriaID(materiaID);
            if (MateriaSeleccionada != null)
            {
                List<Estudiante> alumnos = asignacionesService.GetEstudiantesByMateriaId(materiaID);
                dataGridViewAlumnos.DataSource = alumnos;
            }
            else
            {
                MessageBox.Show("No hay datos que mostrar");
                this.Hide();
            }
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridView()
        {
            dataGridViewAlumnos.AutoGenerateColumns = false;
            dataGridViewAlumnos.DataSource = null;
        }

    }
}
