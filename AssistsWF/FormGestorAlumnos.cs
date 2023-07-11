using AssistsWF.entities;
using AssistsWF.services;
using AssistsWF.Services;
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
    public partial class FormGestorAlumnos : Form
    {
        EstudianteService estudianteService = new EstudianteService();
        MateriasService materiaService = new MateriasService();
        private Estudiante CurrentEstudiante = null;
        private byte Action = 0; //Creando nuevo médico
        public FormGestorAlumnos()
        {
            InitializeComponent();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void button_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
