using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public class Cita
    {
        public DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public eEspecialidades Especialidad { get; set; }
        public string Diagnostico { get; set; }
        //public string Tratamiento { get; set; } 
        //public string NotaMedico { get; set; }  
        //public Guid Id;

        public Cita(DateTime fecha, Medico medico, Paciente paciente)
        {
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
            Especialidad = medico.Especialidad;
        }
        public override string ToString()
        {
            return $"Paciente: {Paciente}, Médico: {Medico} ({Especialidad}), Fecha {Fecha}, Diagnóstico: {Diagnostico}";
        }
    }
}
