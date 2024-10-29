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
        public UpdateMedico()
        {
            InitializeComponent();
        }

        private void UpdateMedico_Load(object sender, EventArgs e)
        {
            Form1 mainForm = this.ParentForm as Form1;
            hospital = mainForm?.HospitalInstance;

            if (hospital != null)
            {
                dataGridViewMedicos.DataSource = hospital.ListaPersonas.OfType<Medico>().ToList();
                hospital.AñadirMedico(new Medico("Alba", "Vidal", 660517673, "vidalba97@gmail.com", eEspecialidades.General,567, 20 ));
                hospital.AñadirMedico(new Medico("Joel", "Adorno", 665435876, "joel@gmail.com", eEspecialidades.Neurología ,345, 35));

                mainForm.RefrescarLista<Medico>(dataGridViewMedicos);
            }
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var medicoSeleccionado = dataGridViewMedicos.SelectedRows[0].DataBoundItem as Medico;
            textBoxNombre.Text = medicoSeleccionado.Nombre;
            textBoxApellido.Text = medicoSeleccionado.Apellido;            
            textBoxTelefono.Text = medicoSeleccionado.Telefono.ToString();            
            textBoxEmail.Text = medicoSeleccionado.Email;
            comboBoxEspcialidad.Text = medicoSeleccionado.Especialidad.ToString();
            textBoxLicencia.Text = medicoSeleccionado.NumeroLicencia.ToString();
            dataGridViewPacientesAsignados.DataSource = medicoSeleccionado.ListaPacientes.OfType<Paciente>().ToList();

        }
    }
}
