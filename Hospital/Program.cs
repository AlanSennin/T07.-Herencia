using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente R = new Paciente();
            Enfermera P = new Enfermera();
            Hombre H = new Hombre();
            Mujer M = new Mujer();
            Medico E = new Medico();
            Enfermera F = new Enfermera();
            Fisioterapeuta A = new Fisioterapeuta();
            Cirujana C = new Cirujana();
            MedicoFamiliar L = new MedicoFamiliar();

            //Objetos de la clase Persona y Paciente (hechos en clase)
            R.Id = 19210494;
            R.Nombre = "Alan Garcia";
            R.Telefono = "664-572-84-89";
            R.TipoDePaciente = "Hombre";
            R.Email = "ryusennin2013@gmail.com";
            P.Area = "Urgencias";

            //Objeto de la clase Hombre y Nombre Heredado de la clase Persona
            H.Nombre = "Brandon Garcia";
            H.LenguaMadre = "Ingles";

            //Objeto de la clase Mujer y Nombre Heredado de la clase Persona
            M.Nombre = "Claudia Garcia";
            M.Nacionalidad = "Estados Unidos";

            //Objeto de la clase Medico y Nombre Heredado de la clase Persona
            E.Nombre = "Fernando Ruiz";
            E.Especialidad = "Veterinario";

            //Objeto de la clase Enfermera y Nombre Heredado de la clase Persona
            F.Nombre = "Melinda Rodriguez";
            F.Area = "Urgencias";

            //Obejeto de la clase Fisioterapeuta y Nombre Heredado de la clase Persona
            A.Nombre = "Alejandro Espinoza";
            A.Universidad = "Universidad Terapeutica de Inglaterra";

            //Objeto de la clase Cirujana y Nombre Heredado de la clase Persona que se lo Hereda a la clase Medico
            C.Nombre = "Ana Karen Leon";
            C.Especialidad = "Cirujano Dental";
            C.Experiencia = "15 años"; //Objeto de la clase Cirujana

            //Objeto de la clase Medico Familiar y Nombre Heredado de la clase Persona que se lo Hereda a la clase Medico
            L.Nombre = "Isaias Paniagua";
            L.Especialidad = "Primeros Auxilios";
            L.Trabajo = "Asistente Dental"; //Objeto de la clase Medico Familiar

            Console.WriteLine("---Objetos de la clase Persona y Paciente (hechos en clase)");
            Console.WriteLine("ID: "+R.Id);
            Console.WriteLine("Nombre: "+R.Nombre);
            Console.WriteLine("Telefono: "+R.Telefono);
            Console.WriteLine("Email: "+R.Email);
            Console.WriteLine("Area: "+P.Area);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Hombre y Nombre Heredado de la clase Persona");
            Console.WriteLine("Nombre: "+H.Nombre);
            Console.WriteLine("Lengua Madre: "+H.LenguaMadre);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Mujer y Nombre Heredado de la clase Persona");
            Console.WriteLine("Nombre: " +M.Nombre);
            Console.WriteLine("Nacionalidad: "+M.Nacionalidad);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Medico y Nombre Heredado de la clase Persona");
            Console.WriteLine("Nombre: " +E.Nombre);
            Console.WriteLine("Especialidad: "+E.Especialidad);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Enfermera y Nombre Heredado de la clase Persona");
            Console.WriteLine("Nombre: " +F.Nombre);
            Console.WriteLine("Area: "+F.Area);

            Console.WriteLine(" ");

            Console.WriteLine("---Obejeto de la clase Fisioterapeuta y Nombre Heredado de la clase Persona");
            Console.WriteLine("Nombre: " + A.Nombre);
            Console.WriteLine("Universisdad: "+A.Universidad);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Cirujana y Nombre Heredado de la clase Persona que se lo Hereda a la clase Medico");
            Console.WriteLine("Nombre: " +C.Nombre);
            Console.WriteLine("Especialidad: "+C.Especialidad);
            Console.WriteLine("Experiencia: "+C.Experiencia);

            Console.WriteLine(" ");

            Console.WriteLine("---Objeto de la clase Medico Familiar y Nombre Heredado de la clase Persona que se lo Hereda a la clase Medico");
            Console.WriteLine("Nombre: " + L.Nombre);
            Console.WriteLine("Especialidad: "+L.Especialidad);
            Console.WriteLine("Trabajo: "+L.Trabajo);

            Console.ReadKey();
        }
    }
}
