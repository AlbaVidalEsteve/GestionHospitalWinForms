using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Persona(string nombre, string apellido, int telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
        }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre ;
        }
    }
}
