using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Administrativo : Persona
    {

        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public Administrativo(string nombre, string apellido, int telefono, string email, string puesto, string departamento) : base(nombre, apellido, telefono, email)
        {
            Puesto = puesto;
            Departamento = departamento;    
        }

        public override string ToString()
        {
            return $"Administrativo: {Nombre}";
        }
    }
}
