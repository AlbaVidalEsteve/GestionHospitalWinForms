using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    
    public enum eEspecialidades
    {
        Cardiología = 1,
        General,
        Neumología,
        Neurología,
        Dermatología,
        Pediatría
    }
    public class Medico : Persona
    {
        public Guid ID { get; private set; }
        public eEspecialidades Especialidad { get; set; }
        public int NumeroLicencia { get; set; }
        public int AnosExperiencia { get; set; }
        public List<Paciente> ListaPacientes {  get; set; }
        public Medico(string nombre,eEspecialidades especialidad) : base(nombre)
        {
            ID = Guid.NewGuid();
            Especialidad = especialidad;
            ListaPacientes = new List<Paciente>();
        }

        public Medico(string nombre, string apellido, int telefono, string email, eEspecialidades especialidad, int numeroLicencia, int anosExperiencia) : base(nombre, apellido, telefono, email)
        {
            ID = Guid.NewGuid();
            Especialidad = especialidad;
            NumeroLicencia = numeroLicencia;
            AnosExperiencia = anosExperiencia;
            ListaPacientes = new List<Paciente>();
        }

        public void MostrarPacientes()
        {
            Console.WriteLine(this);
            if (ListaPacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes asignados.");
            }
            else
            {
                ListaPacientes.ForEach(p =>
                {
                    Console.WriteLine(p);
                });
            }
        }

        public override string ToString()
        {
            return $"Médico: {Nombre} {Apellido} Especialidad: {Especialidad}";
        }

    }


}
