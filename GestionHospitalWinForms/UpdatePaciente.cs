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
        public UpdatePaciente()
        {
            InitializeComponent();
        }

        private void UpdatePaciente_Load(object sender, EventArgs e)
        {
            
            Form1 mainForm = this.ParentForm as Form1;
            hospital = mainForm?.HospitalInstance;

            if (hospital != null)
            {               
                hospital.AñadirPaciente(new Paciente("Alba", "Vidal", "0+", new DateTime(1997, 10, 28), 660517673, "vidalba97@gmail.com"));
                hospital.AñadirPaciente(new Paciente("Joel", "Adorno", "A+", new DateTime(2004, 12, 16), 665435876, "joel@gmail.com"));
                                
                mainForm.RefrescarLista<Paciente>(dataGridViewPacientes);
            }
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
            textBoxNombre.Text = pacienteSeleccionado.Nombre;
            textBoxApellido.Text = pacienteSeleccionado.Apellido;
            dateTimePickerBirth.Value = pacienteSeleccionado.FechaNacimiento;
            textBoxTelefono.Text =pacienteSeleccionado.Telefono.ToString();
            textBoxGrupo.Text = pacienteSeleccionado.GrupoSanguineo;
            textBoxEmail.Text = pacienteSeleccionado.Email;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePickerBirth.Text = "";
            textBoxTelefono.Text = "";
            textBoxGrupo.Text = "";
            textBoxEmail.Text = "";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
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


    }
}
