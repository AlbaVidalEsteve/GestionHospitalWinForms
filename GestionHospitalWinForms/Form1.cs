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

        private void MostrarControl(UserControl control)
        {
            // Limpiar cualquier control previo en el panel
            panelContainer.Controls.Clear();

            // Configurar el UserControl para que ocupe todo el panel
            control.Dock = DockStyle.Fill;

            // Agregar el UserControl al panel
            panelContainer.Controls.Add(control);
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            var gestionPersonal = new GestionPersonas();
            MostrarControl(gestionPersonal);
        }
    }
}
