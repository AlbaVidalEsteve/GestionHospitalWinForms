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
        public Hospital HospitalInstance
        {
            get { return hospital; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
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
            var gestionPersonal = new GestionPersonas();
            MostrarControl(gestionPersonal);
        }

        private void buttonCitas_Click(object sender, EventArgs e)
        {
            var gestionCitas = new GestionCitas();
            MostrarControl(gestionCitas);
        }
    }
}
