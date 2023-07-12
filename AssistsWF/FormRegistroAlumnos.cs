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
    public partial class FormRegistroAlumnos : Form
    {
        // services
        EstudianteService estudianteService = new EstudianteService();
        MateriasService materiaService = new MateriasService();
        AsignacionesService asignacionService = new AsignacionesService();

        private Estudiante CurrentEstudiante = null;
        private List<AsignacionEstudianteMateria> asignaciones = new List<AsignacionEstudianteMateria>();
        private byte Action = 0;
        public FormRegistroAlumnos(Guid IDEstudiante)
        {
            InitializeComponent();
            CargarMaterias();

            if (IDEstudiante != Guid.Empty)
            {
                Action = 1; //Estamos editando
                LlenarDatosEstudiante(IDEstudiante); //Para editar
            }
        }

        public void LlenarDatosEstudiante(Guid IDEstudiante)
        {
            var EstudianteFound = estudianteService.GetEstudianteById(IDEstudiante);

            CurrentEstudiante = EstudianteFound;

            textBoxNombre.Text = EstudianteFound.nombre_estudiante;
            textBoxApellido.Text = EstudianteFound.apellido_estudiante;
            var asignacion = asignacionService.GetAsignacionEstudianteByID(IDEstudiante);

            if (asignacion != null)
            {
                // Marca las materias correspondientes en el CheckedListBox
                foreach (var idMateria in asignacion.id_materias)
                {
                    for (int i = 0; i < checkedListBoxMaterias.Items.Count; i++)
                    {
                        Materia materia = checkedListBoxMaterias.Items[i] as Materia;
                        if (materia != null && materia.id_materia == idMateria)
                        {
                            checkedListBoxMaterias.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error.");
            }
        }



        private void button_Aceptar_Click(object sender, EventArgs e)
        {

            if (CurrentEstudiante == null) //Solo si es un nuevo estudiante
            {
                CurrentEstudiante = new Estudiante()
                {
                    id_estudiante = Guid.NewGuid()
                };
            }

            CurrentEstudiante.nombre_estudiante = textBoxNombre.Text;
            CurrentEstudiante.apellido_estudiante = textBoxApellido.Text;

            List<Guid> idMaterias = new List<Guid>();
            foreach (Materia materia in checkedListBoxMaterias.CheckedItems)
            {
                idMaterias.Add(materia.id_materia);
            }

            if (idMaterias.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una materia.");
                return;
            }

            AsignacionEstudianteMateria asignacion = new AsignacionEstudianteMateria
            {
                id_estudiante = CurrentEstudiante.id_estudiante,
                id_materias = idMaterias
            };

            switch (Action)
            {
                case 0: //Nuevo 
                    if (estudianteService.AddEstudiante(CurrentEstudiante) && asignacionService.AddAsignacion(asignacion))
                    {
                        this.DialogResult = DialogResult.OK;
                        //this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Ocurrio un problema");
                    }
                    break;
                case 1: //Editando 
                    if (estudianteService.EditEstudiante(CurrentEstudiante) && asignacionService.EditAsignacion(asignacion))
                    {
                        this.DialogResult = DialogResult.OK;
                        //this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Ocurrio un problema");
                    }
                    break;
            }
        }

        private void button_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMaterias()
        {
            // Obtén la lista de materias desde tu servicio o fuente de datos
            List<Materia> materias = materiaService.GetAllMaterias();

            // Agrega las materias al CheckedListBox
            foreach (Materia materia in materias)
            {
                checkedListBoxMaterias.Items.Add(materia);
                checkedListBoxMaterias.DisplayMember = "nombre_materia";
            }
        }


    }
}
