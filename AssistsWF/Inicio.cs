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
        private ControlDeAlumnosMateria ventanaMateria;
        MateriasService materiasService = new MateriasService();

        public Inicio()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            LoadDataList();
            listMaterias.SelectionMode = SelectionMode.One;

        }

        private void LoadDataList()
        {
            listMaterias.DataSource = materiasService.GetAllMaterias();
            listMaterias.DisplayMember = "nombre_materia";
            listMaterias.ValueMember = "id_materia";
        }


        private void listMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            establecerVentana();
        }



        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (ventanaMateria != null || ventanaMateria.IsDisposed)
            {
                establecerVentana();
            }

            ventanaMateria.ShowDialog();
        }

        private ControlDeAlumnosMateria establecerVentana()
        {
            {
                Materia materiaSeleccionada = (Materia)listMaterias.SelectedItem;
                Guid materiaID = materiaSeleccionada.id_materia;
                ventanaMateria = new ControlDeAlumnosMateria(materiaID);
                return ventanaMateria;
            }
        }


    }
}
