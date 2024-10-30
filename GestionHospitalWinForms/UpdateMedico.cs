using GestionHospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHospitalWinForms
{
    public partial class UpdateMedico : UserControl
    {
        private Hospital hospital;        
        public UpdateMedico(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            //Form1 mainForm = this.ParentForm as Form1;
        }

        private void UpdateMedico_Load(object sender, EventArgs e)
        {
            Form1 mainForm = this.ParentForm as Form1;            

            if (hospital != null)
            {
               dataGridViewMedicos.DataSource = hospital.ListaPersonas.OfType<Medico>().ToList();
               mainForm.RefrescarLista<Medico>(dataGridViewMedicos);
            }
            //ComboBox Especialidades            
            comboBoxEspecialidad.Items.AddRange(Enum.GetValues(typeof(eEspecialidades)).Cast<object>().ToArray());
            
            dataGridViewMedicos.ClearSelection();
        }
        

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            panelMostrarDatos.Visible = true;
            buttonGuardar.Visible = true;
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            comboBoxEspecialidad.SelectedIndex = 0;
            textBoxLicencia.Text = "";
            textBoxExperiencia.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            dataGridViewPacientesAsignados.DataSource = null;
            dataGridViewMedicos.ClearSelection();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelMostrarDatos.Visible = true;
            buttonGuardar.Visible = true;
            var medicoSeleccionado = dataGridViewMedicos.SelectedRows[0].DataBoundItem as Medico;
            textBoxNombre.Text = medicoSeleccionado.Nombre;
            textBoxApellido.Text = medicoSeleccionado.Apellido;            
            textBoxTelefono.Text = medicoSeleccionado.Telefono.ToString();            
            textBoxEmail.Text = medicoSeleccionado.Email;
            comboBoxEspecialidad.Text = medicoSeleccionado.Especialidad.ToString();
            textBoxLicencia.Text = medicoSeleccionado.NumeroLicencia.ToString();
            textBoxExperiencia.Text = medicoSeleccionado.AnosExperiencia.ToString();
            dataGridViewPacientesAsignados.DataSource = medicoSeleccionado.ListaPacientes.OfType<Paciente>().ToList();
        }

        private void dataGridViewMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicos.SelectedRows.Count > 0)
            {
                // Modificar médico existente
                var medicoSeleccionado = dataGridViewMedicos.SelectedRows[0].DataBoundItem as Medico;
                if (medicoSeleccionado != null)
                {
                    ModificarMedico(medicoSeleccionado);
                }
            }
            else
            {
                // Agregar nuevo médico
                AgregarNuevoMedico();
            }
            panelMostrarDatos.Visible = false;
            buttonGuardar.Visible = false;  
        }


        // Función para agregar un nuevo médico
        private void AgregarNuevoMedico()
        {
            try
            {
                var nombre = textBoxNombre.Text;
                var apellido = textBoxApellido.Text;
                var email = textBoxEmail.Text;

                if (Enum.TryParse(comboBoxEspecialidad.Text, out eEspecialidades especialidad) &&
                    int.TryParse(textBoxLicencia.Text, out int licencia) &&
                    int.TryParse(textBoxExperiencia.Text, out int experiencia) &&
                    int.TryParse(textBoxTelefono.Text, out int telefono))
                {
                    var medicoNuevo = new Medico(nombre, apellido, telefono, email, especialidad, licencia, experiencia);
                    hospital.AñadirMedico(medicoNuevo);

                    MessageBox.Show("Médico añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarListaMedicos();
                }
                else
                {
                    MessageBox.Show("Verifica los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de datos incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para modificar un médico existente
        private void ModificarMedico(Medico medicoSeleccionado)
        {
            medicoSeleccionado.Nombre = textBoxNombre.Text;
            medicoSeleccionado.Apellido = textBoxApellido.Text;
            medicoSeleccionado.Email = textBoxEmail.Text;

            if (comboBoxEspecialidad.SelectedItem != null &&
                Enum.TryParse(comboBoxEspecialidad.SelectedItem.ToString(), out eEspecialidades especialidadSeleccionada))
            {
                medicoSeleccionado.Especialidad = especialidadSeleccionada;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una especialidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(textBoxLicencia.Text, out int numeroLicencia) &&
                int.TryParse(textBoxExperiencia.Text, out int experiencia) &&
                int.TryParse(textBoxTelefono.Text, out int telefono))
            {
                medicoSeleccionado.NumeroLicencia = numeroLicencia;
                medicoSeleccionado.AnosExperiencia = experiencia;
                medicoSeleccionado.Telefono = telefono;

                dataGridViewMedicos.Refresh();
                MessageBox.Show("Médico modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asegúrate de ingresar valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListaMedicos()
        {
            dataGridViewMedicos.DataSource = null;
            dataGridViewMedicos.DataSource = hospital.ListaPersonas.OfType<Medico>().ToList();
        }

    }
}
