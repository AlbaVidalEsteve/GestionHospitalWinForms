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
    public partial class UpdatePaciente : UserControl
    {
        private Hospital hospital;
        public UpdatePaciente(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void UpdatePaciente_Load(object sender, EventArgs e)
        {

            Form1 mainForm = this.ParentForm as Form1;
            

            if (hospital != null)
            {                                  
                mainForm.RefrescarLista<Paciente>(dataGridViewPacientes);
            }

            //ComboBox Medicos
            var medicos = hospital.ListaPersonas.OfType<Medico>().ToList();
            comboBoxMedicos.Items.AddRange(medicos.ToArray());
            comboBoxMedicos.DisplayMember = "Nombre";
            comboBoxMedicos.DataSource = medicos;
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = textBoxNombre.Text;
                var apellido = textBoxApellido.Text;
                var grupoSanguineo = textBoxGrupo.Text;
                var fechaNacimiento = dateTimePickerBirth.Value;
                var telefono = Convert.ToInt32(textBoxTelefono.Text);
                var email = textBoxEmail.Text;

                var pacienteNuevo = new Paciente(nombre, apellido, grupoSanguineo, fechaNacimiento, telefono, email);
                hospital.AñadirPaciente(pacienteNuevo);

                Form1 mainForm = this.ParentForm as Form1;
                mainForm.RefrescarLista<Paciente>(dataGridViewPacientes);

                MessageBox.Show("Paciente añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos ingresados. Por favor, revise e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var pacienteSeleccionado = dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente;
            buttonGuardar.Visible = true;
            buttonBorrar.Visible = true;
            buttonNuevo.Visible = true;
            panelMostrarDatos.Visible = true;
            panelMostrarDatos.Refresh();

            textBoxNombre.Text = pacienteSeleccionado.Nombre;
            textBoxApellido.Text = pacienteSeleccionado.Apellido;
            dateTimePickerBirth.Value = pacienteSeleccionado.FechaNacimiento;
            textBoxTelefono.Text =pacienteSeleccionado.Telefono.ToString();
            textBoxGrupo.Text = pacienteSeleccionado.GrupoSanguineo;
            textBoxEmail.Text = pacienteSeleccionado.Email;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            panelMostrarDatos.Visible = true;
            buttonGuardar.Visible = true;
            buttonBorrar.Visible = true;
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePickerBirth.Text = "";
            textBoxTelefono.Text = "";
            textBoxGrupo.Text = "";
            textBoxEmail.Text = "";            
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {
                // Modificar paciente existente
                var pacienteSeleccionado = dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente;
                if (pacienteSeleccionado != null)
                {
                    ModificarPaciente(pacienteSeleccionado);
                } else
                {
                    // Agregar nuevo`paciente
                    AgregarNuevoPaciente(pacienteSeleccionado);
                }
            }
            //panelMostrarDatos.Visible = false;
            buttonGuardar.Visible = false;
                        
        }

        private void ModificarPaciente(Paciente paciente)
        {
            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {                
                var pacienteSeleccionado = dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente;

                if (pacienteSeleccionado != null)
                {
                    pacienteSeleccionado.Nombre = textBoxNombre.Text;
                    pacienteSeleccionado.Apellido = textBoxApellido.Text;
                    pacienteSeleccionado.FechaNacimiento = dateTimePickerBirth.Value;

                    if (int.TryParse(textBoxTelefono.Text, out int telefono))
                    {
                        pacienteSeleccionado.Telefono = telefono;
                    }
                    else
                    {
                        MessageBox.Show("El teléfono ingresado no es válido. Por favor, ingresa solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    pacienteSeleccionado.GrupoSanguineo = textBoxGrupo.Text;
                    pacienteSeleccionado.Email = textBoxEmail.Text;

                    dataGridViewPacientes.Refresh();

                    MessageBox.Show("Paciente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarNuevoPaciente(Paciente paciente)
        {
            try
            {
                var nombre = textBoxNombre.Text;
                var apellido = textBoxApellido.Text;
                var email = textBoxEmail.Text;
                var grupo = textBoxGrupo.Text;
                DateTime fecha = dateTimePickerBirth.Value;

                if (int.TryParse(textBoxTelefono.Text, out int telefono))
                {
                    var pacienteoNuevo = new Paciente(nombre, apellido, grupo,fecha, telefono, email );
                    hospital.AñadirPaciente(paciente);

                    MessageBox.Show("Paciente añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarListaPaciente();
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

        private void RefrescarListaPaciente()
        {
            dataGridViewPacientes.DataSource = null;
            dataGridViewPacientes.DataSource = hospital.ListaPersonas.OfType<Paciente>().ToList();
        }
    }
}
