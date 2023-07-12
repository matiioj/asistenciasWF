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
    public partial class ListaGeneralAlumnos : Form
    {
        EstudianteService estudianteService = new EstudianteService();
        MateriasService materiaService = new MateriasService();
        AsignacionesService asignacionService = new();
        public ListaGeneralAlumnos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            AsignacionesService asignacionesService = new AsignacionesService();
            List<AsignacionEstudianteMateria> asignaciones = asignacionesService.GetAllAsignaciones();

            // crear DataTable para mostrar los datos
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Materias");

            // Recorre las asignaciones y agrego los datos al DataTable
            foreach (AsignacionEstudianteMateria asignacion in asignaciones)
            {
                // Obtengo el estudiante por ID
                Estudiante estudiante = estudianteService.GetEstudianteById(asignacion.id_estudiante);

                // Obtengo el nombre de la materias por ID
                List<string> nombresMaterias = new List<string>();
                foreach (Guid idMateria in asignacion.id_materias)
                {
                    Materia materia = materiaService.GetMateriaID(idMateria);
                    nombresMaterias.Add(materia.nombre_materia);
                }

                // Combino
                string materias = string.Join(", ", nombresMaterias);

                // Agrego datos al DataTable
                dt.Rows.Add(estudiante.id_estudiante, estudiante.nombre_estudiante, estudiante.apellido_estudiante, materias);
            }

            // DataTable como DataSource
            dataGridViewEstudiantes.DataSource = dt;

            foreach (DataGridViewColumn column in dataGridViewEstudiantes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            FormRegistroAlumnos formRegistro = new(Guid.Empty);
            formRegistro.ShowDialog();
            CargarDatos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstudiantes.SelectedRows.Count > 0)
            {
                FormRegistroAlumnos formRegistro = new FormRegistroAlumnos(Guid.Parse(dataGridViewEstudiantes.CurrentRow.Cells[0].Value.ToString()));
                formRegistro.ShowDialog();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estudiante");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstudiantes.SelectedRows.Count > 0)
            {
                if (estudianteService.DeleteEstudiante(Guid.Parse(dataGridViewEstudiantes.CurrentRow.Cells[0].Value.ToString())) && asignacionService.DeleteAsignacionesEstudiante(Guid.Parse(dataGridViewEstudiantes.CurrentRow.Cells[0].Value.ToString())))
                {
                    CargarDatos();
                    MessageBox.Show("Estudiante eliminado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estudiante");
            }
        }
    }
}
