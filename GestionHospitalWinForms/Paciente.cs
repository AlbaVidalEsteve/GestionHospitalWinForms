using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public class Paciente : Persona
    {
        public Medico MedicoAsignado { get; set; }

        public List<Cita> Historial { get; set; }
         
        public Paciente(string nombre, Medico medico) : base(nombre)
        {
            MedicoAsignado = medico;
            medico.ListaPacientes.Add(this);
            Historial = new List<Cita>();
        }
        public Paciente(string nombre) : base(nombre)
        {
            Historial = new List<Cita>();
        }
        public override string ToString()
        {
            return $"Paciente: {Nombre}";
        }
    }
}
