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
    public partial class GestionPersonas : UserControl
    {
        private Hospital hospital;
        public GestionPersonas()
        {
            InitializeComponent();
        }

        private void GestionPersonas_Load(object sender, EventArgs e)
        {
            Form1 mainForm = this.ParentForm as Form1;
            Hospital hospital = mainForm.HospitalInstance;
            dataGridView1.DataSource = hospital.ListaPersonas;
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            var listaPacientes = hospital.ListaPersonas.OfType<Paciente>().ToList();
            dataGridView1.DataSource = listaPacientes;
        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {
            var listaMedicos = hospital.ListaPersonas.OfType<Medico>().ToList();
            dataGridView1.DataSource = listaMedicos;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var listaAdministrativos = hospital.ListaPersonas.OfType<Paciente>().ToList();
            dataGridView1.DataSource = listaAdministrativos;
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            var listaTodos = hospital.ListaPersonas.ToList();
            dataGridView1.DataSource = listaTodos;
        }

        
    }
}
