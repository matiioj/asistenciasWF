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
    public partial class Inicio : Form
    {
        MateriasService materiasService = new MateriasService();
        public Usuario UserSession;

        public Inicio(Usuario returned)
        {
            InitializeComponent();
            UserSession = returned;
            labelNombre.Text = returned.Nombre + " " + returned.Apellido;
            LoadDataList();
            listMaterias.SelectionMode = SelectionMode.One;

        }

        private void LoadDataList()
        {
            listMaterias.DataSource = materiasService.GetAllMaterias();
            listMaterias.DisplayMember = "nombre_materia";
            listMaterias.ValueMember = "id_materia";
        }

        private bool ventanaAbierta = false;

        private void listMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ventanaAbierta)
            {
                ventanaAbierta = true;
                Materia materiaSeleccionada = (Materia)listMaterias.SelectedItem;
                ControlDeAlumnos ventanaMateria = new ControlDeAlumnos(materiaSeleccionada);

                ventanaMateria.FormClosed += (s, args) => { ventanaAbierta = false; };
                ventanaMateria.ShowDialog();
            }
        }

        


    }
}
