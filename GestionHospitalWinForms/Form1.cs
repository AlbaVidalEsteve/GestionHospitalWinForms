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
    public partial class Form1 : Form
    {
        private Hospital hospital;
        public Form1()
        {
            InitializeComponent();
            hospital = new Hospital();            
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            hospital.AnadirDatosEjemplo();
        }

        public void MostrarControl(UserControl control)
        {
           panelContainer.Controls.Clear();

           control.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(control);
        }

        public void RefrescarLista<T>(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = hospital.ListaPersonas.OfType<T>().ToList();
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            var updatePaciente = new UpdatePaciente(hospital);
            MostrarControl(updatePaciente);
        }

        private void buttonCitas_Click(object sender, EventArgs e)
        {
            var gestionCitas = new GestionCitas();
            MostrarControl(gestionCitas);
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {

        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            var updatePacientes = new UpdatePaciente(hospital);            
            MostrarControl(updatePacientes);
        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {
            var updateMedicos = new UpdateMedico(hospital);            
            MostrarControl(updateMedicos);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
