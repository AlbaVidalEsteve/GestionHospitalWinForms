using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    
    public class Hospital
    {
        public List<Persona> ListaPersonas { get; set; }
        public List<Cita> ListaCitas { get; set; }
        public Hospital()
        {
            ListaPersonas = new List<Persona>();
            ListaCitas = new List<Cita>();
        }

        public string GetNombre<T>()
        {
            Console.WriteLine($"Introduce el nombre del {typeof(T).Name.ToLower()}:");
            return Console.ReadLine();
        }
        public void AñadirAdministrativo()
        {
            //string nombre = GetNombre<Administrativo>();
            //Administrativo administrativo = new Administrativo(nombre,apellido, telefono,email, puesto,departamento);
            //ListaPersonas.Add(administrativo);
        }
        public void AñadirPaciente(Paciente paciente)
        {
            //string nombre = GetNombre<Paciente>();
            //Paciente paciente = new Paciente(nombre);
            ListaPersonas.Add(paciente);
        }

        public void borrarPaciente(Paciente paciente)
        {
            //string nombre = GetNombre<Paciente>();
            //Paciente paciente = new Paciente(nombre);
            ListaPersonas.Remove(paciente);
        }

        public void AñadirMedico(Medico medico)
        {            
            ListaPersonas.Add(medico);
        }
        public void borrarMedico(Medico medico)
        {            
            ListaPersonas.Remove(medico);
        }
        public void AnadirDatosEjemplo()
        {
            Medico medico1 = new Medico(
                nombre: "Dr. Juan",
                apellido: "Pérez",
                telefono: 123456789,
                email: "juan.perez@hospital.com",
                especialidad: eEspecialidades.Cardiología,
                numeroLicencia: 10293,
                anosExperiencia: 15
            );
            ListaPersonas.Add(medico1);


            Medico medico2 = new Medico(nombre: "Dr. Luis",
                apellido: "Martínez",
                telefono: 111222333,
                email: "luis.martinez@hospital.com",
                especialidad: eEspecialidades.Neumología,
                numeroLicencia: 20485,
                anosExperiencia: 8
            );
            ListaPersonas.Add(medico2);
            Medico medico3 = new Medico(
                nombre: "Dra. Clara",
                apellido: "Ruiz",
                telefono: 222333444,
                email: "clara.ruiz@hospital.com",
                especialidad: eEspecialidades.Dermatología,
                numeroLicencia: 37456,
                anosExperiencia: 12
            );
            ListaPersonas.Add(medico3);

            Medico medico4 = new Medico(
                nombre: "Dr. Alejandro",
                apellido: "Fernández",
                telefono: 333444555,
                email: "alejandro.fernandez@hospital.com",
                especialidad: eEspecialidades.Neurología,
                numeroLicencia: 48567,
                anosExperiencia: 10
            );
            ListaPersonas.Add(medico4);
            Paciente paciente1 = new Paciente(
                nombre: "Ana",
                apellido: "García",
                grupo: "A+",
                fecha: new DateTime(1990, 5, 15),
                telefono: 987654321,
                email: "ana.garcia@correo.com"
            );
            ListaPersonas.Add(paciente1);
            paciente1.MedicoAsignado = medico1;
            medico1.ListaPacientes.Add(paciente1);

            Paciente paciente2 = new Paciente(
                nombre: "Carlos",
                apellido: "López",
                grupo: "A+",
                fecha: new DateTime(1985, 3, 22),
                telefono: 555123456,
                email: "carlos.lopez@correo.com"
            );
            ListaPersonas.Add(paciente2);

            paciente2.MedicoAsignado = medico2;
            medico2.ListaPacientes.Add(paciente2);

            Paciente paciente3 = new Paciente(
                nombre: "Juan",
                apellido: "Pérez",
                grupo: "B+",
                fecha: new DateTime(1978, 5, 14),
                telefono: 555789123,
                email: "juan.perez@correo.com"
            );
            ListaPersonas.Add(paciente3);

            paciente3.MedicoAsignado = medico3;
            medico3.ListaPacientes.Add(paciente3);

            Paciente paciente4 = new Paciente(
                nombre: "María",
                apellido: "Hernández",
                grupo: "O-",
                fecha: new DateTime(1992, 7, 18),
                telefono: 555654321,
                email: "maria.hernandez@correo.com"
            );
            ListaPersonas.Add(paciente4);

            paciente4.MedicoAsignado = medico4;
            medico4.ListaPacientes.Add(paciente4);


            Cita cita1 = new Cita(
                fecha: new DateTime(2024, 11, 5, 10, 30, 0), // 5 de Noviembre de 2024 a las 10:30 am
                medico: medico1,
                paciente: paciente1
            );

            cita1.Diagnostico = "Revisión general";

            Administrativo admin1 = new Administrativo(
                nombre: "Laura",
                apellido: "Gómez",
                telefono: 555123456,
                email: "laura.gomez@hospital.com",
                puesto: "Recepcionista",
                departamento: "Admisiones"
            );
            ListaPersonas.Add(admin1);


        }
        public void AsignarMédico()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            Medico medicoAsignado = BuscarPersona<Medico>();
            if (paciente != null && medicoAsignado != null)
            {
                paciente.MedicoAsignado = medicoAsignado;
                medicoAsignado.ListaPacientes.Add(paciente);
            }
            else
            {
                Console.WriteLine("Paciente o Médico no encontrado.");
            }
        }
        public void CambiarMedico()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            Medico medicoNuevo = BuscarPersona<Medico>();
            if (paciente != null && medicoNuevo != null)
            {
                if (paciente.MedicoAsignado != medicoNuevo)
                {
                    paciente.MedicoAsignado.ListaPacientes.Remove(paciente);
                    medicoNuevo.ListaPacientes.Add(paciente);
                    paciente.MedicoAsignado = medicoNuevo;
                }
                else
                {
                    Console.WriteLine("El paciente ya tiene asignado este médico.");
                }
            }
            else
            {
                Console.WriteLine("Paciente o médico no encontrado.");
            }
        }
        public void MostrarPersonal() 
        {
         Console.WriteLine($"En el hospital hay:{ListaPersonas.Count}");
            foreach(Persona persona in ListaPersonas)
            {
                Console.WriteLine(persona);
            }
        }
        public T BuscarPersona<T>() where T : Persona
        {
            string nombre = GetNombre<T>();
            return ListaPersonas.OfType<T>().FirstOrDefault(p => p.Nombre == nombre);
        }
        public void DarDeAlta()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            Medico medico = BuscarPersona<Medico>();
            if (medico.ListaPacientes.Contains(paciente))
            {
                medico.ListaPacientes.Remove(paciente);
                ListaPersonas.Remove(paciente);

                Console.WriteLine($"Paciente {paciente.Nombre} dado de alta.");
            }
            else
            {
                Console.WriteLine($"El paciente {paciente.Nombre} no está en la lista de este médico.");
            }
        }
        public void DarCita()
        {
            Paciente paciente = BuscarPersona<Paciente>();
            Medico medico = BuscarPersona<Medico>();
            Cita cita = new Cita(EscogerFecha(), medico, paciente);
            //Guid guid = Guid.NewGuid();
            //cita.Id = guid;
            ListaCitas.Add(cita);
        }
        //public void AñadirRegistro()
        //{
        //    Paciente paciente = BuscarPersona<Paciente>();
        //    Medico medico = BuscarPersona<Medico>();
        //    RegistroMedico registro = new RegistroMedico(medico, paciente);
        //    paciente.Historial.Add(registro);
        //}
        public List<Cita> ConsultarCitas()
        {
            Persona persona = BuscarPersona<Persona>();
            switch (persona)
            {
                case Medico m:
                    var citasMedico = ListaCitas.Where(c => c.Medico == m).ToList();
                    if (citasMedico.Count > 0)
                    {
                        Console.WriteLine($"Citas del médico {m.Nombre}:");
                        foreach (var (cita, index) in citasMedico.Select((cita, index) => (cita, index)))
                        {
                            Console.WriteLine($"[{index + 1}] Paciente: {cita.Paciente.Nombre}, Fecha: {cita.Fecha}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El médico {m.Nombre} no tiene citas.");
                    }
                    return citasMedico;

                case Paciente p:
                    var citasPaciente = ListaCitas.Where(c => c.Paciente == p).ToList();
                    if (citasPaciente.Count > 0)
                    {
                        Console.WriteLine($"Citas del paciente {p.Nombre}:");
                        foreach (var (cita, index) in citasPaciente.Select((cita, index) => (cita, index)))
                        {
                            Console.WriteLine($"[{index + 1}] Médico: {cita.Medico.Nombre}, Fecha: {cita.Fecha}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El paciente {p.Nombre} no tiene citas.");
                    }
                    return citasPaciente;

                default:
                    Console.WriteLine("La persona no es un médico ni un paciente.");
                    return new List<Cita>();
            }
        }
        public void MostrarCitas(List<Cita> citas)
        {
            if (citas.Count > 1)
            {
                Console.WriteLine("Lista de Citas: ");

                for (int i = 0; i < citas.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] Cita con el Dr. {citas[i].Medico.Nombre}, Fecha: {citas[i].Fecha}");
                }

            }
            else
            {
                Console.WriteLine("No hay citas.");
            }
        }
        public Cita SeleccionarCita()
        {
            List<Cita> citas = ConsultarCitas();
            if (citas.Count > 1)
            {
                if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= citas.Count)
                {
                    Cita citaSeleccionada = citas[seleccion - 1];
                    return citaSeleccionada;
                }
                else
                {
                    return null;
                }
            }
            else if (citas.Count == 1)
            {
                Cita unicaCita = citas.First();
                return unicaCita;
            }
            else
            {
                return null;
            }
        }
        public void CancelarCita()
        { 
            Cita citaSeleccionada = SeleccionarCita();
            ListaCitas.Remove(citaSeleccionada); 
            Console.WriteLine($"Cita cancelada: Médico: {citaSeleccionada.Medico.Nombre}, Fecha: {citaSeleccionada.Fecha}");    
        }
        public void ModificarCita()
        {
            Cita citaSeleccionada = SeleccionarCita();
            Console.WriteLine($"Cita seleccionada: Médico: {citaSeleccionada.Medico.Nombre}, Fecha: {citaSeleccionada.Fecha}");
            Console.WriteLine("--- Dato a modificar: ---" +
                "\n [1] Médico" +
                "\n [2] Paciente" +
                "\n [3] Fecha");
            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= 3)
            {
                switch (seleccion)
                {
                    case 1:
                        Medico medicoNuevo = BuscarPersona<Medico>();
                        citaSeleccionada.Medico = medicoNuevo;
                        break;
                    case 2:
                        Paciente pacienteNuevo = BuscarPersona<Paciente>();
                        citaSeleccionada.Paciente = pacienteNuevo;
                        break;
                    case 3:
                        DateTime fechaNueva = EscogerFecha();
                        citaSeleccionada.Fecha = fechaNueva;
                        break;
                }
            }
        }

        public void AñadirDiagnostico()
        {
            Cita cita = SeleccionarCita();
            Console.WriteLine("Escribe el diagnóstico:");
            string diagnostico = Console.ReadLine();
            cita.Diagnostico = diagnostico; 
        }
        public DateTime EscogerFecha()
        {
            int diaMes, mes, año, hora, minutos;

            Console.WriteLine("Escoge el día del mes: (Número)");
            while (!int.TryParse(Console.ReadLine(), out diaMes) || diaMes < 1 || diaMes > 31)
            {
                Console.WriteLine("Por favor, introduce un día válido (1-31).");
            }

            Console.WriteLine("Escoge el mes: (Número)");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Por favor, introduce un mes válido (1-12).");
            }

            Console.WriteLine("Escoge el año: (Número)");
            while (!int.TryParse(Console.ReadLine(), out año) || año < 1)
            {
                Console.WriteLine("Por favor, introduce un año válido (mayor que 0).");
            }

            Console.WriteLine("Escoge la hora: (Número)");
            while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23)
            {
                Console.WriteLine("Por favor, introduce una hora válida (0-23).");
            }

            Console.WriteLine("Escoge los minutos: (Número)");
            while (!int.TryParse(Console.ReadLine(), out minutos) || minutos < 0 || minutos > 59)
            {
                Console.WriteLine("Por favor, introduce minutos válidos (0-59).");
            }

            
            if (diaMes > DateTime.DaysInMonth(año, mes))
            {
                Console.WriteLine($"El mes {mes} del año {año} solo tiene {DateTime.DaysInMonth(año, mes)} días. Por favor, introduce un día válido.");
                return EscogerFecha();
            }
            DateTime fecha = new DateTime(año, mes, diaMes, hora, minutos, 0);
            return fecha;
        }

    }
}

