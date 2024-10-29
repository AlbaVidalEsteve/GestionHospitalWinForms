using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public class Paciente : Persona
    {

        public string GrupoSanguineo { get; set; }
        public DateTime FechaNacimiento { get; set; }
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

        public Paciente(string nombre, string apellido, string grupo, DateTime fecha, int telefono, string email) : base(nombre, apellido, telefono, email)
        {
            GrupoSanguineo = grupo;
            FechaNacimiento = fecha;
            Historial = new List<Cita>();
        }
        public override string ToString()
        {
            return $"Paciente: {Nombre}";
        }
    }
}
